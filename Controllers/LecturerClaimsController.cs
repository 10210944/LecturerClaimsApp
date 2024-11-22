using LecturerClaimsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LecturerClaimsApp.Controllers
{
    public class LecturerClaimsController : Controller
    {
       
        private static List<LecturerClaim> _claims = new List<LecturerClaim>();

        
        // This method displays the list of claims for managing
        public IActionResult Index()
        {
   
            return View(_claims); // This will render the "Index.cshtml" view with the list of claims
        }

        
        // This method returns the Create view for submitting a new claim
        [HttpGet]
        public IActionResult Create()
        {
            return View(); // Render the "Create.cshtml" form view
        }

        
        // This method handles the form submission for creating a new claim
        [HttpPost]
        public IActionResult Create(LecturerClaim newClaim)
        {
            if (ModelState.IsValid)
            {
                // Add the new claim to the list with a unique ClaimId
                newClaim.ClaimId = _claims.Count + 1;

                
                if (newClaim.HoursWorked >= 10) // auto-approve claims with 10 or more hours worked
                {
                    newClaim.Status = "Approved";
                }
                else if (newClaim.HoursWorked <= 0 || newClaim.HourlyRate <= 0) // auto-reject Example
                {
                    newClaim.Status = "Rejected";
                    newClaim.RejectionReason = "Invalid data (hours worked or hourly rate is zero or negative).";
                }
                else
                {
                    // If none of the auto-approve or auto-reject conditions are met, set to pending
                    newClaim.Status = "Pending";
                }

                // Add the new claim to the list
                _claims.Add(newClaim);

                
                return RedirectToAction("Index");
            }

            
            return View(newClaim);
        }

        
        // This method allows approving a claim manually
        [HttpPost]
        public IActionResult Approve(int id)
        {
            var claim = _claims.FirstOrDefault(c => c.ClaimId == id);
            if (claim != null)
            {
                claim.Status = "Approved";
            }
            return RedirectToAction("Index");
        }

        
        // This method allows rejecting a claim manually
        [HttpPost]
        public IActionResult Reject(int id, string rejectionReason)
        {
            var claim = _claims.FirstOrDefault(c => c.ClaimId == id);
            if (claim != null)
            {
                claim.Status = "Rejected";
                claim.RejectionReason = rejectionReason; // Save the rejection reason
            }
            return RedirectToAction("Index");
        }
    }
}
