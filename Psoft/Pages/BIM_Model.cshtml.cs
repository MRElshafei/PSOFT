using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_Projects;
using Psoft.Domain;

namespace Psoft.Pages.WebsitePages
{
    public class BIM_ModelModel : PageModel
    {

        private readonly IManageProject Project;
        public string ProjectName { get; set; }
        public string WexBIMUploadedFileUrl { get; set; }
        private readonly IManageProjects manageProjects;

        public BIM_ModelModel(IManageProject manageProject, IManageProjects manageProjects)
        {
            this.Project = manageProject;
            this.manageProjects = manageProjects;
        }
        public void OnGet()
        {
            ProjectName = manageProjects.getActivatedProjectName();
            var path = manageProjects.getPathOfActivatedProject();
            Building Project = new Building();

            var wexPath = Project.getWEXBIM(path);
            string fileName = "CrossBIMBuilding.wexBIM";
            var uploadParams = new RawUploadParams()
            {  // by default, ResourceType is already set to "raw"
                File = new FileDescription(wexPath),
                Folder = "PSOFT",
                PublicId = fileName  //File New Name
            };
            Account account = new Account(
                  "dyavm0bhs",
                  "793996812682882",
                  "aklpFkL6fzMzYJMduGepwL83UU0");
            Cloudinary cloudinary = new Cloudinary(account);
            var uploadResult = cloudinary.Upload(uploadParams);

            WexBIMUploadedFileUrl = uploadResult.SecureUrl.ToString();


        }
    }
}
