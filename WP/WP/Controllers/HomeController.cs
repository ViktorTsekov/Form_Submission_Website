using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WP.Data;
using WP.Models;

namespace WP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Accept(Form form)
        {
            var temp = await db.Forms
                .FirstOrDefaultAsync(x => x.Id == form.Id);
            temp.Status = "Accepted";
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Decline(Form form)
        {
            var temp = await db.Forms
                .FirstOrDefaultAsync(x => x.Id == form.Id);
            temp.Status = "Declined";
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index()
        {
            var user = await db.Users
                .Include(x => x.Forms)
                .FirstOrDefaultAsync(x => x.UserName == HttpContext.User.Identity.Name);

           
            List<Form> forms;

            try
            {
                if (user.Role == "Admin")
                {
                    forms = db.Forms.ToList();
                }
                else
                {
                    if (user.Forms == null)
                    {
                        forms = new List<Form>() { new Form() };
                    }
                    else forms = user.Forms;
                }
            }
            catch
            {
                forms = new List<Form>() { new Form() };
            }
            
            return View(forms);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Uverenie()
        {
            return View();
        }

        public IActionResult Complaint()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Complaint(Form form)
        {
            _logger.LogInformation($"{form.Faculty} {HttpContext.User.Identity.Name}");
            var user = await db.Users
                .Include(x => x.Forms)
                .FirstOrDefaultAsync(x => x.UserName == HttpContext.User.Identity.Name);

            form.Status = "Pending";
            user.Forms.Add(form);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ComplaintView(string id)
        {
            var form = await db.Forms.FirstOrDefaultAsync(x => x.Id == id);
            return View(form);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
