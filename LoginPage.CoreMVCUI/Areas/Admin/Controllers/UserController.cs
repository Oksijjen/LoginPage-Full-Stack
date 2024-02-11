using LoginPage.Business.Abstract;
using LoginPage.Business.Concrate;
using LoginPage.DataAccess.Concrate.EntityFramework.context;
using LoginPage.Model.Entity;
using LoginPage.Model.ViewModel.Areas.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginPage.CoreMVCUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UserController : Controller
	{
		private readonly IUserBS _userBs;

		public IActionResult LogIn()
		{
			LogInVm model = new LogInVm();

			return View(model);
		}
		[HttpPost]
		public IActionResult LogIn(LogInVm vm)
		{
			if (ModelState.IsValid)
			{
				User userr = _userBs.Get(x => x.Email == vm.Email && x.Password == vm.Password);
				if (userr != null)
				{
					return Redirect("/Admin/Home/Index");
				}
				else
				{
					ViewBag.Mesaj = "Giriş Başarısız";
					return View(vm);
				}
			}
			else
			{
				ViewBag.Mesaj = "İşlemler HATALI";
				return View(vm);
			}
		}
	}
}
