using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_code
{
    public partial class FormRemoveProject : Form
    {
        public FormRemoveProject()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            Console.WriteLine(FormProject.selectedProjectName);
            Console.WriteLine(Projects.SelectedItem);

            Preference Selection = new Preference();
            string SelectedItem = Projects.SelectedItem.ToString();
            string[] ListedString = SelectedItem.Split('-');
            Selection.Value = ListedString[0].Trim();
            Selection.Name = ListedString[1].Trim();

            if (FormProject.selectedProjectName == Selection.Name)
            {
                MessageBox.Show("Cannot remove your current session project.", "Cannot Remove Current Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            else
            {
                FakeProjectRepository projects = new FakeProjectRepository();
                List<Project> removeProject = new List<Project>();
                removeProject = projects.GetAll();
                Project remove = new Project();

                foreach (Project project in removeProject)
                {
                    if (project.Name == Selection.Name)
                    {
                        remove = project;
                    }
                }
                DialogResult confirmation;
                confirmation = MessageBox.Show("Are you sure you'd like to remove this project?", "Remove Project", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes) removeProject.Remove(remove);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormRemoveProject_Load(object sender, EventArgs e)
        {
            Projects.Items.Clear();
            FakeProjectRepository Project_Repo = new FakeProjectRepository();
            List<Project> existing_projects = Project_Repo.GetAll();
            foreach (Project p in existing_projects)
            {
                string str = p.Id.ToString() + " - " + p.Name;
                Projects.Items.Add(str);
            }
        }
    }
}
