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
    public partial class FormCreateProject : Form
    {
        public FormCreateProject()
        {
            InitializeComponent();
        }

        private static int newProjectID = 4;

        private List<Project> existingProjects = new List<Project>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ProjectNameBox.TextLength == 0)
            {
                MessageBox.Show("Project name is empty or blank.", "Empty Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ProjectNameBox.Text = ProjectNameBox.Text.Trim();

            FakeProjectRepository newProjectList = new FakeProjectRepository();
            existingProjects = newProjectList.GetAll();

            foreach (Project projectName in existingProjects)
            {
                if (projectName.Name == ProjectNameBox.Text)
                {
                    MessageBox.Show("Project name already exists.", "Duplicate Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }
            }

            Project project = new Project();
            project.Id = newProjectID;
            project.Name = ProjectNameBox.Text;
            existingProjects.Add(project);

            newProjectID++;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
