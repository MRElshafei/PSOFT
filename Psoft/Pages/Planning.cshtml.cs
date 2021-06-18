using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_Projects;
using Psoft.Domain;

namespace Psoft.Pages.WebsitePages
{
    public class PlanningModel : PageModel
    {
        public string ProjectName { get; set; }
        public List<Beam> ListOfBeams { set; get; }
        public List<Column> ListOfColumns { set; get; }
        public List<Slab> ListOfSlabs { set; get; }
        public List<Wall> ListOfWalls { set; get; }
        private readonly IManageProject project;
        private readonly IManageProjects manageProjects;

        public PlanningModel(IManageProject manageProject, IManageProjects manageProjects)
        {
            this.project = manageProject;
            this.manageProjects = manageProjects;
        }
        public IActionResult OnGet()
        {
            ProjectName = manageProjects.getActivatedProjectName();
            string Path = manageProjects.getPathOfActivatedProject();
            if (Path == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                Building MyProject = new Building(Path);
                this.ListOfColumns = project.InitializeColumn(MyProject.XmlFile);

                this.ListOfSlabs = project.InitializeSlab(MyProject.XmlFile);

                this.ListOfWalls = project.InitializeWall(MyProject.XmlFile);

                this.ListOfBeams = project.InitializeBeam(MyProject.XmlFile);
                return Page();
            }
        }
    }
}
