using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_code
{
    public class FakeProjectRepository : IProjectRepository
    {
        private static List<Project> projects;

        public FakeProjectRepository()
        {
            projects = new List<Project>();
            projects.Add(new Project
            {
                Id = 1,
                Name = "Accounting Project"
            });
            projects.Add(new Project
            {
                Id = 2,
                Name = "Big Expensive Project"
            });
            projects.Add(new Project
            {
                Id = 3,
                Name = "Some other project"
            });
        }

        public List<Project> GetAll()
        {
            return projects;
        }

    }
}
