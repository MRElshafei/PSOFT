using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_Projects;
using Psoft.Domain;

namespace Psoft.Pages.Project
{
    public class EditProjectModel : PageModel
    {
        private readonly IManageProjects manageProjects;
        private readonly IWebHostEnvironment webHostEnvironment;
        public EditProjectModel(IManageProjects manageProjects
                                 ,IWebHostEnvironment webHostEnvironment)
        {
            this.manageProjects = manageProjects;
            this.webHostEnvironment = webHostEnvironment;
        }
        [BindProperty]
        public Projects Project { get; set; }
        [BindProperty]
        public IFormFile ifcFile { get; set; }
        public string filePath { get; set; }
        public void OnGet(int projectId)
        {
            if (projectId == 0)
            {
                Project = new Projects();
            }
            else
            {
                Project = manageProjects.GetProjectsById(projectId); 
            }
        }
        public IActionResult OnPost()
        {
            if (Project.ID > 0)
            {
                if (ifcFile != null || ifcFile==null)
                {
                    // If a new photo is uploaded, the existing photo must be
                    // deleted. So check if there is an existing photo and delete
                    if (Project.Path != null)
                    {
                        string filePath = Path.Combine(webHostEnvironment.WebRootPath,
                            "ifcfile", Project.Path);
                        System.IO.File.Delete(filePath);
                    }
                    // Save the new photo in wwwroot/images folder and update
                    // PhotoPath property of the employee object
                    Project.Path = ProcessUploadedFile();
                }
                manageProjects.EditProject(Project);
            }
            else
            {
                if (ifcFile != null)
                {
                    // If a new photo is uploaded, the existing photo must be
                    // deleted. So check if there is an existing photo and delete
                    if (Project.Path != null)
                    {
                        string filePath = Path.Combine(webHostEnvironment.WebRootPath,
                            "ifcfile", Project.Path);
                        System.IO.File.Delete(filePath);
                    }
                    // Save the new photo in wwwroot/images folder and update
                    // PhotoPath property of the employee object
                    Project.Path = ProcessUploadedFile();
                }
                manageProjects.AddProject(Project);
            }
            return RedirectToPage("./Projects");
        }
        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;

            if (ifcFile != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "ifcfile");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ifcFile.FileName;
                 filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ifcFile.CopyTo(fileStream);
                }
            }

            return filePath;
        }
    }
}
