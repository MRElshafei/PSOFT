using Microsoft.EntityFrameworkCore;
using Psoft.Application.Manage_Project;
using Psoft.Data;
using Psoft.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Psoft.Application.Manage_Projects
{
    public class ManageProjects : IManageProjects
    {
        private readonly PsoftDBContext dBContext;

        public ManageProjects(PsoftDBContext DBContext)
        {
            dBContext = DBContext;
        }
        public void ActivateProject(int project)
        {
            var activeProject= dBContext.projects.Where(p => p.IsActive == true && p.IsDeleted == false).SingleOrDefault();
            if (activeProject==null)
            {
                dBContext.projects.SingleOrDefault(np => np.ID == project && np.IsDeleted == false).IsActive = true;
            }
            else 
            {
                activeProject.IsActive = false;
                dBContext.projects.SingleOrDefault(np => np.ID == project && np.IsDeleted == false).IsActive = true;
            }
            dBContext.SaveChanges();
        }

        public void AddProject(Projects project)
        {
            dBContext.projects.Add(project);
            //project.ID = dBContext.projects.Max(p=>p.ID)+1;
            dBContext.SaveChanges();
        }

        public void DeleteProject(int project)
        {
            dBContext.projects.SingleOrDefault(p=>p.ID== project).IsDeleted = true;
            dBContext.SaveChanges();
        }

        public List<Projects> DisplayAllProjects()
        {
           return dBContext.projects.Where(p => p.IsDeleted == false).ToList();
        }

        public int ProjectCount()
        {
            var value = dBContext.projects.Where(p => p.IsDeleted == false).ToList().Count();

            if (value > 0)
            {
                return value;
            }
            else
            {
                return 0;
            }
        }

        public void EditProject(Projects project)
        {
           var NewProject = dBContext.projects.Find(project.ID);
            if (NewProject != null)
            {
                NewProject.ProjectName = project.ProjectName;
                NewProject.Path = project.Path;
                NewProject.Location = project.Location;
            }
            dBContext.SaveChanges();
        }

        public string getPathOfActivatedProject()
        {
            var path = dBContext.projects.Where(p => p.IsActive == true && p.IsDeleted == false).FirstOrDefault().Path;
           
                return path;
        }

        public Projects GetProjectsById(int project)
        {
           return dBContext.projects.Where(p=>p.ID== project && p.IsDeleted==false).SingleOrDefault();
        }

        public string getActivatedProjectName()
        {
            if (dBContext.projects.Where(p => p.IsDeleted == false).Count() > 0)
            {
                return dBContext.projects.SingleOrDefault(p => p.IsActive == true && p.IsDeleted == false).ProjectName;
            }
            else
            {
                return "...";
            }
        }

        public int? getActivatedProjectTeam()
        {
            
            if (dBContext.projects.Where(p => p.IsDeleted == false).Count() > 0)
            {
                return dBContext.projects.SingleOrDefault(p => p.IsActive == true && p.IsDeleted == false).ProjectTeam;
            }
            else
            {
                return 0;
            }
        }
    }
}
