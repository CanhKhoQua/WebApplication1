using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class Name : Controller
	{
		public JsonResult name()
		{
			string output = false ? "Loc Nguyen" : "Loc Nguyen";
			return Json(output);
		}

	}
}
