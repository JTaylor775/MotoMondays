using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotoMondays.Data;
using MotoMondays.Models;

namespace MotoMondays.Controllers
{
    public class MaintenanceTicketController : Controller
    {
        private readonly ApplicationDbContext _context;

        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public MaintenanceTicketController(UserManager<User> usrMgr, SignInManager<User> signInMgr, ApplicationDbContext context)
        {
            userManager = usrMgr;
            signInManager = signInMgr;
            _context = context;
        }

        // GET: MaintenanceTicket
        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                int userId = int.Parse(userManager.GetUserId(User));
                var applicationDbContext = _context.MaintenanceTickets.Include(m => m.User).Include(m => m.Motorcycle).Where(m => m.UserID == userId);
                if (User.IsInRole("Administrator") || User.IsInRole("Employee"))
                {
                    applicationDbContext = _context.MaintenanceTickets.Include(m => m.User).Include(m => m.Motorcycle);
                }
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: MaintenanceTicket/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTicket = await _context.MaintenanceTickets
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MaintenanceTicketID == id);
            if (maintenanceTicket == null)
            {
                return NotFound();
            }

            return View(maintenanceTicket);
        }

        // GET: MaintenanceTicket/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "FirstName");
            ViewData["MotorcycleID"] = new SelectList(_context.Motorcycles, "MotorcycleID", "MotorcycleID");

            return View();
        }

        // POST: MaintenanceTicket/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaintenanceTicketID,TicketDescription,DateSubmitted,Completed,UserID, MotorcycleID")] MaintenanceTicket maintenanceTicket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maintenanceTicket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "FirstName", maintenanceTicket.UserID);
            ViewData["MotorcycleID"] = new SelectList(_context.Motorcycles, "MotorcycleID", "MotorcycleID", maintenanceTicket.MotorcycleID);
            return View(maintenanceTicket);
        }

        // GET: MaintenanceTicket/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTicket = await _context.MaintenanceTickets.FindAsync(id);
            if (maintenanceTicket == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "FirstName", maintenanceTicket.UserID);
            ViewData["MotorcycleID"] = new SelectList(_context.Motorcycles, "MotorcycleID", "MotorcycleID", maintenanceTicket.MotorcycleID);
            return View(maintenanceTicket);
        }

        // POST: MaintenanceTicket/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaintenanceTicketID,TicketDescription,DateSubmitted,Completed,UserID, MotorcycleID")] MaintenanceTicket maintenanceTicket)
        {
            if (id != maintenanceTicket.MaintenanceTicketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maintenanceTicket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceTicketExists(maintenanceTicket.MaintenanceTicketID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "FirstName", maintenanceTicket.UserID);
            ViewData["MotorcycleID"] = new SelectList(_context.Motorcycles, "MotorcycleID", "MotorcycleID", maintenanceTicket.MotorcycleID);
            return View(maintenanceTicket);
        }

        // GET: MaintenanceTicket/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTicket = await _context.MaintenanceTickets
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MaintenanceTicketID == id);
            if (maintenanceTicket == null)
            {
                return NotFound();
            }

            return View(maintenanceTicket);
        }

        // POST: MaintenanceTicket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maintenanceTicket = await _context.MaintenanceTickets.FindAsync(id);
            _context.MaintenanceTickets.Remove(maintenanceTicket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceTicketExists(int id)
        {
            return _context.MaintenanceTickets.Any(e => e.MaintenanceTicketID == id);
        }
    }
}
