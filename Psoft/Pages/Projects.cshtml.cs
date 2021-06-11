using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_Project;
using Psoft.Application.Manage_Projects;
using Psoft.Domain;

namespace Psoft.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly IManageProjects manageProject;

        public ProjectsModel(IManageProjects manageProject)
        {
            this.manageProject = manageProject;
        }

        public List<Projects> projects { get; set; }
        public void OnGet()
        {
            projects = manageProject.DisplayAllProjects();
        }
    }
}
