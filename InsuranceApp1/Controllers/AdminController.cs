using InsuranceApp1.Models;
using InsuranceApp1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceApp1.Controllers
{
    public class AdminController : Controller
    {
		// GET: Admin
		public ActionResult Index()
		{
			using (Insurance2Entities db = new Insurance2Entities())
			{
				var customerInfos = db.CustomerInfoes.ToList();
				var customerInfoVms = new List<CustomerInfoVm>();
				foreach (var customerInfo in customerInfos)
				{
					var customerInfoVm = new CustomerInfoVm();
					customerInfoVm.Id = customerInfo.Id;
					customerInfoVm.FirstName = customerInfo.FirstName;
					customerInfoVm.LastName = customerInfo.LastName;
					customerInfoVm.EmailAddress = customerInfo.EmailAddress;
					customerInfoVm.Quote = customerInfo.Quote.ToString();
					customerInfoVms.Add(customerInfoVm);
				}
			return View(customerInfoVms);
			}
        }
    }
}