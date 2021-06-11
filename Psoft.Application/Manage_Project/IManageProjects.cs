using Psoft.Application.Manage_Project;
using Psoft.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psoft.Application.Manage_Projects
{
   public  interface IManageProjects
    {
        List<Projects> DisplayAllProjects();
        Projects GetProjectsById(int project);
        void ActivateProject(int project);
        void AddProject(Projects project);
        void EditProject(Projects project);
        void DeleteProject(int project);
        int ProjectCount();
        string getPathOfActivatedProject();
        string getActivatedProjectName();
    }
}
