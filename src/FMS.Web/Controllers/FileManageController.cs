using Microsoft.AspNet.Mvc;

namespace FMS.Web.Controllers
{
    public class FileManageController : Controller
    {
        public FileManageController()
        {
        }


        //
        // GET: /FileManage/FileUpload
        public IActionResult FileUpload()
        {
            return View();
        }
    }
}
