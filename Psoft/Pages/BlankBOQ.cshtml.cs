using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Pages;

namespace Psoft.Pages
{
    public class BlankBOQModel : PageModel
    {
      

        public void OnGet()
        {
            

          /*  return new RazorPageAsPdf(this);  */     // we don't need page path because it can be determined by current route
        }
    }
}

