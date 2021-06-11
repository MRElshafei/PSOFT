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
    public class DeleteProjectModel : PageModel
    {
        private readonly IManageProjects manageProjects;

        public DeleteProjectModel(IManageProjects manageProjects)
        {
            this.manageProjects = manageProjects;
           
        }
        public IActionResult OnGet(int projectId)
        {
            manageProjects.DeleteProject(projectId);
            return RedirectToPage("./Projects");
        }
    }
}
