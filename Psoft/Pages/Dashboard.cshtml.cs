using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Psoft.Application.Manage_Projects;
using Psoft.Domain;

namespace Psoft.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IManageProjects manageProjects;

        public IndexModel(ILogger<IndexModel> logger,IManageProjects manageProjects)
        {
            _logger = logger;
            this.manageProjects = manageProjects;
        }

        public int ProjectCount { get; set; }
        public  string Project  { get; set; }
        public void OnGet()
        {
            ProjectCount = manageProjects.ProjectCount();
            Project = manageProjects.getActivatedProjectName();
        }
    }
}
