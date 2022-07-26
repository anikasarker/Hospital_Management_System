using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    public class PatientInformationsController : Controller
    {
        private readonly HospitalManagementSystemContext _context;

        public PatientInformationsController(HospitalManagementSystemContext context)
        {
            _context = context;
        }

        // GET: PatientInformations
        public async Task<IActionResult> Index()
        {
            return View(await _context.PatientInformation.ToListAsync());
        }

        // GET: PatientInformations/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientInformation = await _context.PatientInformation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientInformation == null)
            {
                return NotFound();
            }

            return View(patientInformation);
        }

        // GET: PatientInformations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PatientInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Gender,Phone,Age,Blood_Group,Disease,Occupation,EntryDate")] PatientInformation patientInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patientInformation);
        }

        // GET: PatientInformations/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientInformation = await _context.PatientInformation.FindAsync(id);
            if (patientInformation == null)
            {
                return NotFound();
            }
            return View(patientInformation);
        }

        // POST: PatientInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Gender,Phone,Age,Blood_Group,Disease,Occupation,EntryDate")] PatientInformation patientInformation)
        {
            if (id != patientInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientInformationExists(patientInformation.Id))
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
            return View(patientInformation);
        }

        // GET: PatientInformations/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientInformation = await _context.PatientInformation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientInformation == null)
            {
                return NotFound();
            }

            return View(patientInformation);
        }

        // POST: PatientInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var patientInformation = await _context.PatientInformation.FindAsync(id);
            _context.PatientInformation.Remove(patientInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientInformationExists(long id)
        {
            return _context.PatientInformation.Any(e => e.Id == id);
        }
    }
}
