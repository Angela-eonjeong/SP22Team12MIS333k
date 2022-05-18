using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//Change this using statement to match your project
using SetupProject.DAL;
using SetupProject.Models;
using SetupProject.Utilities;
using System;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;

//Change this namespace to match your project
namespace SetupProject.Controllers
{
    public enum UserStatusEnum { Active, Inactive }
    
    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }


        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl; //pass along the page the user should go back to
            return View();
        }


        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string returnUrl)
        {
            //if user forgot to include user name or password,
            //send them back to the login page to try again
            if (ModelState.IsValid == false)
            {
                return View(lvm);
            }

            //attempt to sign the user in using the SignInManager
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);

            //if the login worked, take the user to either the url
            //they requested OR the homepage if there isn't a specific url
            if (result.Succeeded)
            {
                String username = lvm.Email;
                AppUser currentUser = _context.Users.FirstOrDefault(r => r.UserName == username);

                if (currentUser.UserStatus == "Inactive")
                {
                    await _signInManager.SignOutAsync();
                    return View("Error", new string[] { "Account is Disabled." });
                }
                return Redirect(returnUrl ?? "/");
        }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(lvm);
    }


}


        // GET: /Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel rvm, LoginViewModel LoginModel)
        {
            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid)
            {
                AppUser newUser = new AppUser
                    {
                        UserName = rvm.Email,
                        Email = rvm.Email,
                        PhoneNumber = rvm.PhoneNumber,

                        //Add the rest of the custom user fields here
                        //NOTE: Not sure if we need to include PhoneNumber because it is already included in Identity User
                        //FirstName is included as an example
                        FirstName = rvm.FirstName,
                        LastName = rvm.LastName,
                        Address = rvm.Address,
                        City = rvm.City,
                        State = rvm.State,
                        Zip = rvm.Zip
                    };

                newUser.UserStatus = "Active";

                IdentityResult result = await _userManager.CreateAsync(newUser, rvm.Password);
                if (result.Succeeded)
                {
                    //TODO: Add user to desired role
                    //This will not work until you have seeded Identity OR added the "Customer" role 
                    //by navigating to the RoleAdmin controller and manually added the "Customer" role

                    await _userManager.AddToRoleAsync(newUser, "Customer");
                    string emailsubject = "New Account";
                    string emailbody = "Congratulations! You just created a new account with Bevo Books!";
                    SendEmail(rvm.Email, emailbody, emailsubject);

                    
                    Microsoft.AspNetCore.Identity.SignInResult result1 = await _signInManager.PasswordSignInAsync(LoginModel.Email, LoginModel.Password, LoginModel.RememberMe, lockoutOnFailure: false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                   foreach (IdentityError error in result.Errors)
                   {
                       ModelState.AddModelError("", error.Description);
                   }
                }
            }

            return View(rvm);
        }





        //GET: Account/Index
        [Authorize]
        public IActionResult Index(string id)
        {

            if (id == null)
            {
                id = User.Identity.Name;
            }

            IndexViewModel ivm = new IndexViewModel();

            //get user info

            AppUser user = _context.Users
                                   .Include(r => r.PaymentMethods)
                                   .FirstOrDefault(u => u.UserName == id);

            //populate the view model
            //(i.e. map the domain model to the view model)
                ivm.Id = user.Id;
                ivm.Email = user.Email;
                ivm.HasPassword = true;
                ivm.UserName = user.UserName;
                ivm.FirstName = user.FirstName;
                ivm.LastName = user.LastName;
                ivm.Address = user.Address;
                ivm.City = user.City;
                ivm.State = user.State;
                ivm.Zip = user.Zip;
                ivm.PhoneNumber = user.PhoneNumber;
                

           return View(ivm);
            ///////

        }


        //GET: Account/Edit
        [Authorize]
        public ActionResult ModifyAccount(string id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "ID is null" });

            }

            var account = _context.Users.FirstOrDefault(c => c.Id == id);
            if (account == null)
            {
                return View("Error", new string[] { "account is null" });

            }

            ModifyAccountViewModel mvm = new ModifyAccountViewModel();

            mvm.FirstName = account.FirstName;
            mvm.LastName = account.LastName;
            mvm.Address = account.Address;
            mvm.City = account.City;
            mvm.State = account.State;
            mvm.Zip = account.Zip;
            mvm.PhoneNumber = account.PhoneNumber;

            return View(mvm);

        }


        //POST: /Account/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult ModifyAccount(ModifyAccountViewModel account)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser dbAccount = _context.Users
                                                .FirstOrDefault(c => c.Id == account.Id);

                    dbAccount.FirstName = account.FirstName;
                    dbAccount.LastName = account.LastName;
                    dbAccount.Address = account.Address;
                    dbAccount.City = account.City;
                    dbAccount.State = account.State;
                    dbAccount.Zip = account.Zip;
                    dbAccount.PhoneNumber = account.PhoneNumber;

                    _context.Update(dbAccount);
                    _context.SaveChanges();

                  

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("Index");
            }
            return View(account);
        }




        //Logic for change password
        // GET: /Account/ChangePassword
        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }



        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel cpvm)
        {
            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            //Find the logged in user using the UserManager
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            //Attempt to change the password using the UserManager
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, cpvm.OldPassword, cpvm.NewPassword);

            //if the attempt to change the password worked
            if (result.Succeeded)
            {
                //sign in the user with the new password
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                String emailsubject = "Password Changed";
                String emailbody = "Your password to Bevo Books has been changed.";
                SendEmail(userLoggedIn.Email, emailbody, emailsubject);

                //send the user back to the home page
                return RedirectToAction("Index", "Home");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send the user back to the change password page to try again
                return View(cpvm);
            }
        }

        //GET:/Account/AccessDenied
        public IActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            //sign the user out of the application
            _signInManager.SignOutAsync();

            //send the user back to the home page
            return RedirectToAction("Index", "Home");
        }






        ///////// CUSTOMER ACCOUNT MANAGE CONTROLLER ///////////////////////////////////
        //Manage Customer accounts (like an index)
        [Authorize(Roles = "Admin, Employee")]
        public async Task<ActionResult> ManageCustomerAccounts()
        {
            List<AppUser> allCustomers = new List<AppUser>();
            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();

            foreach (AppUser user in _userManager.Users)
            {
                var customerList = await _userManager.IsInRoleAsync(user, "Customer") ? members : nonMembers;
                customerList.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.Members = members;

            foreach (var customer in re.Members)
            {
                allCustomers.Add(customer);
            }

            //return allCustomers;

            return View(allCustomers);
        }


        //GET
        [Authorize(Roles = "Admin, Employee")]
        public ActionResult CreateCustomerAccount()
        {
            return View();
        }



        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Employee")]
        public async Task<ActionResult> CreateCustomerAccount(RegisterViewModel model, LoginViewModel LoginModel)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    City = model.City,
                    State = model.State,
                    Zip = model.Zip,
                };

                user.UserStatus = "Active";

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
           
                    await _userManager.AddToRoleAsync(user, "Customer");
                    String emailbody = "Thank you for creating a new account with Bevo Books!";
                    String emailsubject = "New Account";
                    SendEmail(model.Email, emailbody, emailsubject);

                    
                    return RedirectToAction("ManageCustomerAccounts", "Account"); 
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);

        }



        //Edit a selected customer account
        //GET: /Account/Edit
        [Authorize(Roles = "Admin, Employee")]
        public ActionResult EditCustomerAccount(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = _context.Users.FirstOrDefault(c => c.Id == id);
            if (account == null)
            {
                return NotFound();
            }
            ModifyAccountViewModel mvm = new ModifyAccountViewModel();
            mvm.FirstName = account.FirstName;
            mvm.LastName = account.LastName;
            mvm.Address = account.Address;
            mvm.City = account.City;
            mvm.State = account.State;
            mvm.Zip = account.Zip;
            mvm.PhoneNumber = account.PhoneNumber;
            return View(mvm);
        }


        //POST: /Account/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Employee")]
        public IActionResult EditCustomerAccount(ModifyAccountViewModel account)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser dbAccount = _context.Users
                        .FirstOrDefault(c => c.Id == account.Id);

                    dbAccount.FirstName = account.FirstName;
                    dbAccount.LastName = account.LastName;
                    dbAccount.Address = account.Address;
                    dbAccount.City = account.City;
                    dbAccount.State = account.State;
                    dbAccount.Zip = account.Zip;
                    dbAccount.PhoneNumber = account.PhoneNumber;

                    _context.Update(dbAccount);
                    _context.SaveChanges();



                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("ManageCustomerAccounts");
            }
            return View(account);
        }



        //edit a customer or employee user status
        [Authorize(Roles = "Admin, Employee")]
        public ActionResult ChangeCustomerUserStatus(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppUser account = _context.Users.FirstOrDefault(c => c.Id == id);

            if (account == null)
            {
                return NotFound();
            }

            //want to return a whether UserStatus is "Active" or "Inactive" --> done in view

            return View(account);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Employee")]
        public async Task<ActionResult> ChangeCustomerUserStatus(string id, UserStatusEnum SelectedUserStatus)
        {
            AppUser currentUser = _context.Users.FirstOrDefault(c => c.Id == id);

            if (SelectedUserStatus == UserStatusEnum.Active)
            {
                currentUser.UserStatus = "Active";
            }
            else
            {
                currentUser.UserStatus = "Inactive";
            }

            //figure out if this is right
            _context.Update(currentUser);
            _context.SaveChanges();


            //repopulate list of all customers
            List<AppUser> allCustomers = new List<AppUser>();

            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                var customerList = await _userManager.IsInRoleAsync(user, "Customer") ? members : nonMembers;
                customerList.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.Members = members;

            foreach (var customer in re.Members)
            {
                allCustomers.Add(customer);
            }

            //return allCustomers;

            return View("ManageCustomerAccounts", allCustomers);
        }



        [Authorize(Roles = "Admin, Employee")]
        public ActionResult ChangeCustomerPassword(string id)
        {
            ChangeOtherPasswordViewModel selectedAccount = new ChangeOtherPasswordViewModel();
            selectedAccount.AccountSelectedID = id;

            return View(selectedAccount);
        }


        // POST: /Account/ChangeCustomerPassword
        [Authorize(Roles = "Admin, Employee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> ChangeCustomerPassword(ChangeOtherPasswordViewModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser customerSelected = await _userManager.FindByIdAsync(id);
            var result = await _userManager.ChangePasswordAsync(customerSelected, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                //don't want to sign in when password is changed
                //await _signInManager.SignInAsync(customerSelected, isPersistent: false);
                String emailsubject = "Password Changed";
                String emailbody = "Your password to Bevo Books has been changed.";
                SendEmail(customerSelected.Email, emailbody, emailsubject);
                return RedirectToAction("ManageCustomerAccounts", "Account");
            }
            AddErrors(result);
            return View(model);
        }



        /////////// Employ Account Manage ///////////
        //manage employee accounts (like an index page)
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ManageEmployeeAccounts()
        {
            //return View(await _context.Books.Include(m => m.Genre).ToListAsync());
            List<AppUser> allEmployees = new List<AppUser>();

            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                var customerList = await _userManager.IsInRoleAsync(user, "Employee") ? members : nonMembers;
                customerList.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.Members = members;

            foreach (var employee in re.Members)
            {
                allEmployees.Add(employee);
            }

            //return allCustomers;

            return View(allEmployees);
        }



        //GET
        [Authorize(Roles = "Admin")]
        public ActionResult CreateEmployeeAccount()
        {
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> CreateEmployeeAccount(RegisterViewModel model, LoginViewModel LoginModel)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    City = model.City,
                    State = model.State,
                    Zip = model.Zip

                };

                user.UserStatus = "Active";
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    

                    await _userManager.AddToRoleAsync(user, "Employee");
                    String emailbody = "Congratulations! You are now an employee with Bevo Books!";
                    String emailsubject = "New Account";
                    SendEmail(model.Email, emailbody, emailsubject);

                    //Do not want to sign this person in
                    //Microsoft.AspNetCore.Identity.SignInResult result1 = await _signInManager.PasswordSignInAsync(LoginModel.Email, LoginModel.Password, LoginModel.RememberMe, lockoutOnFailure: false);

                    return RedirectToAction("ManageEmployeeAccounts", "Account"); //this is like the index page
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);

        }


        //edit a customer or employee user status
        [Authorize(Roles = "Admin")]
        public ActionResult ChangeEmployeeUserStatus(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppUser account = _context.Users.FirstOrDefault(c => c.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            //want to return a whether UserStatus is "Active" or "Inactive" --> done in view

            return View(account);
        }




        //POST: /Account/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ChangeEmployeeUserStatus(string id, UserStatusEnum SelectedUserStatus)
        {
            AppUser currentUser = _context.Users.FirstOrDefault(c => c.Id == id);

            if (SelectedUserStatus == UserStatusEnum.Active)
            {
                currentUser.UserStatus = "Active";
            }
            else
            {
                currentUser.UserStatus = "Inactive";
            }

            //figure out if this is right
            _context.Update(currentUser);
            _context.SaveChanges();


            //repopulate list of all customers
            List<AppUser> allEmployees = new List<AppUser>();

            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                var customerList = await _userManager.IsInRoleAsync(user, "Employee") ? members : nonMembers;
                customerList.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.Members = members;

            foreach (var employee in re.Members)
            {
                allEmployees.Add(employee);
            }

            //return allCustomers;

            return View("ManageEmployeeAccounts", allEmployees);
        }



        //GET: /Account/Edit
        [Authorize(Roles = "Admin")]
        public ActionResult EditEmployeeAccount(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = _context.Users.FirstOrDefault(c => c.Id == id);
            if (account == null)
            {
                return NotFound();
            }
            ModifyAccountViewModel mvm = new ModifyAccountViewModel();
            mvm.FirstName = account.FirstName;
            mvm.LastName = account.LastName;
            mvm.Address = account.Address;
            mvm.City = account.City;
            mvm.State = account.State;
            mvm.Zip = account.Zip;
            mvm.PhoneNumber = account.PhoneNumber;
            return View(mvm);
        }






        //POST: /Account/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult EditEmployeeAccount(ModifyAccountViewModel account)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser dbAccount = _context.Users
                        .FirstOrDefault(c => c.Id == account.Id);

                    dbAccount.FirstName = account.FirstName;
                    dbAccount.LastName = account.LastName;
                    dbAccount.Address = account.Address;
                    dbAccount.City = account.City;
                    dbAccount.State = account.State;
                    dbAccount.Zip = account.Zip;
                    dbAccount.PhoneNumber = account.PhoneNumber;

                    _context.Update(dbAccount);
                    _context.SaveChanges();

                    //edit department/course relationships


                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("ManageEmployeeAccounts");
            }
            return View(account);
        }



        [Authorize(Roles = "Admin")]
        public ActionResult ChangeEmployeePassword(string id)
        {
            ChangeOtherPasswordViewModel selectedAccount = new ChangeOtherPasswordViewModel();
            selectedAccount.AccountSelectedID = id;

            return View(selectedAccount);
        }



        // POST: 
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> ChangeEmployeePassword(ChangeOtherPasswordViewModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser employeeSelected = await _userManager.FindByIdAsync(id);
            var result = await _userManager.ChangePasswordAsync(employeeSelected, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                //don't want to sign in when password is changed
                //await _signInManager.SignInAsync(customerSelected, isPersistent: false);
                String emailsubject = "Password Changed";
                String emailbody = "Your password to Bevo Books has been changed.";
                SendEmail(employeeSelected.Email,emailbody, emailsubject);
                return RedirectToAction("ManageEmployeeAccounts", "Account");
            }
            AddErrors(result);
            return View(model);
        }




        ///// Plus 

        public void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }



        public bool AccountExists(string id)
        {
            throw new NotImplementedException();
        }
   

        public static void SendEmail (string ToAddress, string emailBody, string emailSubject)
        {
                String fromAddress = "t03131553@gmail.com";
                String fromPassword = "Abc123!!";
                String fromCompanyName = "MIS 333K Final Project Team 12";

                 var client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress, fromPassword),
                        EnableSsl = true
                    };

                String finalMessage = emailBody + "\n\n Thank you.";

                //Create an email address object for the sender address
                MailAddress senderEmail = new MailAddress(fromAddress, fromCompanyName);

                //Create a new mail message
                MailMessage mm = new MailMessage();

                //Set the subject line of the message (including your team number)
                //TODO: Change XX to your team number.
                mm.Subject = "Team 12 - " + emailSubject;

                //Set the sender address
                mm.Sender = senderEmail;

                //Set the from address
                mm.From = senderEmail;

                //Add the recipient (passed in as a parameter) to the list of people receiving the email
                mm.To.Add(new MailAddress(ToAddress));

                //Add the message (passed)
                mm.Body = finalMessage;

                //send the message!
                client.Send(mm);
        }
    }
}

