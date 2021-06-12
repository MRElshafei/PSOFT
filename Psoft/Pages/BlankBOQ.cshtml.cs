using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_BOQ;
using Psoft.Application.Manage_Projects;
using Psoft.Domain;

namespace Psoft.Pages
{
    public class BlankBOQModel : PageModel
    {

        private readonly IManageProject Project;

        public string ProjectName { get; set; }

        private readonly IManageBOQ IManageBOQ;

        IManageProjects manageProjects;

        [BindProperty]
        public BOQDTO _BOQDTO { get; set; }
        public BOQ _BOQ { get; set; }

        [BindProperty]
        public BOQDTOList BOQDTOList { get; set; }



        public BOQDTOList ItemsList { get; set; }

        public BlankBOQModel(IManageProject manageProject, IManageBOQ IManageBOQ, IManageProjects manageProjects)
        {
            this.Project = manageProject;

            this.IManageBOQ = IManageBOQ;

            this.manageProjects = manageProjects;
        }
        public void OnGet()
        {
            ItemsList = IManageBOQ.GetITemsList();

            ProjectName = manageProjects.getActivatedProjectName();


            ProjectName = manageProjects.getActivatedProjectName();

            string Path = manageProjects.getPathOfActivatedProject();



        }
    }
}

