using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_BOQ;
using Psoft.Application.Manage_Projects;
using Psoft.Domain;

namespace Psoft.Pages.WebsitePages
{
    public class BOQModel : PageModel
    {
        public List<Beam> ListOfBeams { set; get; }
        public List<Column> ListOfColumns { set; get; }
        public List<Slab> ListOfSlabs { set; get; }
        public List<Wall> ListOfWalls { set; get; }
        private readonly IManageProject Project;

        private readonly IManageProjects manageProjects;

        public string ProjectName { get; set; }

        private readonly IManageBOQ IManageBOQ;


        public BOQDTOList ItemsList { get; set; }

        public BOQModel(IManageProject manageProject, IManageBOQ IManageBOQ, IManageProjects manageProjects)
        {

            this.Project = manageProject;

            this.IManageBOQ = IManageBOQ;

            this.manageProjects = manageProjects;
        }

        public IActionResult OnGet()
        {


            ItemsList = IManageBOQ.GetITemsList();


            ProjectName = manageProjects.getActivatedProjectName();

            string Path = manageProjects.getPathOfActivatedProject();
            if (Path == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                Building MyProject = new Building(Path);

                this.ListOfColumns = Project.InitializeColumn(MyProject.XmlFile);

                this.ListOfSlabs = Project.InitializeSlab(MyProject.XmlFile);

                this.ListOfWalls = Project.InitializeWall(MyProject.XmlFile);

                this.ListOfBeams = Project.InitializeBeam(MyProject.XmlFile);
                return Page();
            }
        }
    }
}

