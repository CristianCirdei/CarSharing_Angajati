using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarSharing_Angajati.Models;

namespace CarSharing_Angajati.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly CarSharingDbContext _context;

        public EmployeesController(CarSharingDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
              return View(await _context.Employees.ToListAsync());
        }


        // GET: Employees/AddorEdit
  public IActionResult AddorEdit(int id=0)
        {
            if(id == 0)
                return View(new Employees());
            else
                return View(_context.Employees.Find(id));
        }


        // POST: Employees/AddorEdit   
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddorEdit([Bind("EmpId,EmpName,EmpBirthDate,EmpIDNP,Gender,EmpEmail,EmpAdress,EmpPhoneNumber,EmpDriverLicense, EmpPosition")] Employees employees)
        {
            if (ModelState.IsValid)                                             
            {
                if (employees.EmpId== 0)
                {
                    _context.Add(employees);
                }
                else
                _context.Update(employees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employees);
        }


        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employees = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
