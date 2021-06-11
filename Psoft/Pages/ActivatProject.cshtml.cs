using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_Projects;
using Psoft.Domain;

namespace Psoft.Pages
{
    public class ActivatProjectModel : PageModel
    {
        private readonly IManageProjects manageProjects;

        public ActivatProjectModel(IManageProjects manageProjects)
        {
            this.manageProjects = manageProjects;
        }
        public IActionResult OnGet(int project)
        {
            manageProjects.ActivateProject(project);
            return RedirectToPage("./Projects");
        }
    }
}
