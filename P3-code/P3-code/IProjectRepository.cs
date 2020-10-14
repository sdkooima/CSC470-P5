using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_code
{
    public interface IProjectRepository
    {
       
        public string Add(Project project, int Id);

        public string remove(int projectID);

        public string Modify(int projectID, Project project);

        public bool IsDuplicateName(string ProjectName);
      
        List<Project> GetAll();
    }
}
