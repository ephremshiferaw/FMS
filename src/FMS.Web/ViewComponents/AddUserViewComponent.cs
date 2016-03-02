using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMS.Web.ViewModels.Administrator;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ViewComponents;

namespace FMS.Web.ViewComponents
{
    public class AddUserViewComponent: ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {    
          
            await Task.Delay(1); 
            return View(new UserViewModel());
        }
    }
}
