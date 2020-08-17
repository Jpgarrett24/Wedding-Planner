using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        //for each route this controller is to handle:
        [HttpGet("")]     //Http Method and the route
        public IActionResult Index() //When in doubt, use IActionResult
        {
            Wrapper Wrapper = new Wrapper();
            return View("Index", Wrapper); //or whatever you want to return
        }

        [HttpPost("")]
        public IActionResult Register(Wrapper Form)
        {
            //Check if form passes validations
            if (ModelState.IsValid)
            {
                //Check if Email is alreagy registered
                if (_context.Users.Any(u => u.Email == Form.User.Email))
                {
                    ModelState.AddModelError("User.Email", "Email already registered");
                    return Index();
                }

                //Hash Password and Save User to Database
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                Form.User.Password = Hasher.HashPassword(Form.User, Form.User.Password);
                _context.Add(Form.User);
                _context.SaveChanges();

                //Assign registered user to session
                User NewUser = _context.Users.FirstOrDefault(u => u.Email == Form.User.Email);
                int UserId = NewUser.UserId;
                HttpContext.Session.SetInt32("CurrentUser", UserId);

                //Redirect to page
                return RedirectToAction("Dashboard");
            }
            else
            {
                return Index();
            }
        }

        [HttpPost("login")]
        public IActionResult Login(Wrapper Form)
        {
            //Check if form passes validations
            if (ModelState.IsValid)
            {
                //Check database for user with provided email address
                User ReturningUser = _context.Users.FirstOrDefault(u => u.Email == Form.LoginUser.LoginEmail);
                if (ReturningUser == null)
                {
                    ModelState.AddModelError("LoginUser.LoginEmail", "Invalid Email Address/Password");
                    return Index();
                }

                //Check if password provided matches returning user in database
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(Form.LoginUser, ReturningUser.Password, Form.LoginUser.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginUser.LoginEmail", "Invalid Email Address/Password");
                    return Index();
                }

                //If Email/Password are correct. Add user to session and redirect.
                HttpContext.Session.SetInt32("CurrentUser", ReturningUser.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return Index();
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            Wrapper Wrapper = new Wrapper();
            User ActiveUser = _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("CurrentUser"));
            if (ActiveUser == null)
            {
                return RedirectToAction("Index");
            }
            Wrapper.User = ActiveUser;
            foreach (Wedding wedding in _context.Weddings.ToList())
            {
                if (wedding.Date < DateTime.Now)
                {
                    _context.Weddings.Remove(wedding);
                    _context.SaveChanges();
                }
            }
            Wrapper.AllWeddings = _context.Weddings.Include(w => w.Guests).ThenInclude(g => g.User).ToList();
            Wrapper.CurrentUser = (int)HttpContext.Session.GetInt32("CurrentUser");
            return View("Dashboard", Wrapper);
        }

        [HttpGet("wedding/new")]
        public IActionResult WeddingForm()
        {
            Wrapper Wrapper = new Wrapper();
            User ActiveUser = _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("CurrentUser"));
            if (ActiveUser == null)
            {
                return RedirectToAction("Index");
            }
            return View("NewWedding");
        }

        [HttpPost("wedding/new")]
        public IActionResult CreateWedding(Wrapper Form)
        {
            if (ModelState.IsValid)
            {
                Form.Wedding.UserId = (int)HttpContext.Session.GetInt32("CurrentUser");
                _context.Weddings.Add(Form.Wedding);
                _context.SaveChanges();
                Wedding NewWedding = _context.Weddings.FirstOrDefault(w => w.WedderOne == Form.Wedding.WedderOne && w.WedderTwo == Form.Wedding.WedderTwo);
                return RedirectToAction("Details", new { id = NewWedding.WeddingId });
            }
            else
            {
                return WeddingForm();
            }
        }

        [HttpGet("wedding/{id}")]
        public IActionResult Details(int id)
        {
            User CurrentUser = _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("CurrentUser"));
            if (CurrentUser == null)
            {
                return RedirectToAction("Index");
            }
            Wrapper Wrapper = new Wrapper();
            Wrapper.Wedding = _context.Weddings.Include(w => w.Guests).ThenInclude(g => g.User).FirstOrDefault(w => w.WeddingId == id);
            if (Wrapper.Wedding == null)
            {
                return Dashboard();
            }
            return View("WeddingDetails", Wrapper);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            User ActiveUser = _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("CurrentUser"));
            if (ActiveUser == null)
            {
                return RedirectToAction("Index");
            }
            Wedding ToDelete = _context.Weddings.FirstOrDefault(w => w.WeddingId == id);
            _context.Weddings.Remove(ToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("RSVP")]
        public IActionResult RSVP(int userID, int weddingID)
        {
            User user = _context.Users.FirstOrDefault(u => u.UserId == userID);
            Wedding wedding = _context.Weddings.FirstOrDefault(w => w.WeddingId == weddingID);
            GuestList newGuest = new GuestList();
            newGuest.UserId = userID;
            newGuest.WeddingId = weddingID;
            newGuest.User = user;
            newGuest.Wedding = wedding;
            _context.GuestLists.Add(newGuest);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("UNRSVP")]
        public IActionResult UNRSVP(int userID, int weddingID)
        {
            GuestList ToDelete = _context.GuestLists.FirstOrDefault(g => g.UserId == userID && g.WeddingId == weddingID);
            _context.Remove(ToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
