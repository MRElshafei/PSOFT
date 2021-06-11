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
    public class CostEstimationModel : PageModel
    {
        public List<Beam> ListOfBeams { set; get; }
        public List<Column> ListOfColumns { set; get; }
        public List<Slab> ListOfSlabs { set; get; }
        public List<Wall> ListOfWalls { set; get; }
        private readonly IManageProject Project;

        private readonly IManageBOQ IManageBOQ;

        IManageProjects manageProjects;

        [BindProperty]
        public BOQDTO _BOQDTO { get; set; }
        public BOQ _BOQ { get; set; }

        [BindProperty]
        public BOQDTOList BOQDTOList { get; set; }



        public BOQDTOList ItemsList { get; set; }

        public CostEstimationModel(IManageProject manageProject, IManageBOQ IManageBOQ,IManageProjects manageProjects)
        {
            this.Project = manageProject;

            this.IManageBOQ = IManageBOQ;

            this.manageProjects = manageProjects;
        }

        public IActionResult OnGet(int? ItemId)
        {


            ItemsList = IManageBOQ.GetITemsList();


            string Path = manageProjects.getPathOfActivatedProject();
            if (Path == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {


                ItemsList = IManageBOQ.GetITemsList();

                Building MyProject = new Building(Path);

                this.ListOfColumns = Project.InitializeColumn(MyProject.XmlFile);

                this.ListOfSlabs = Project.InitializeSlab(MyProject.XmlFile);

                this.ListOfWalls = Project.InitializeWall(MyProject.XmlFile);

                this.ListOfBeams = Project.InitializeBeam(MyProject.XmlFile);
            
            

            if (!ItemId.HasValue)
                {

                    _BOQDTO = new BOQDTO();



                }
                else
                {
                    _BOQDTO = IManageBOQ.GetItemsById(ItemId.Value);
                }

                return Page();

            }
        }
        public IActionResult OnPost()
        {
            foreach (var item in BOQDTOList.BOQs)
            {
                IManageBOQ.AddItem(item);

            }
            if (_BOQDTO.ID > 0)
            {
                IManageBOQ.EditItem(_BOQDTO);
            }
            else
            {
                IManageBOQ.AddItem(_BOQDTO);
            }
            return RedirectToPage("./CostEstimation");
        }
    }
}
