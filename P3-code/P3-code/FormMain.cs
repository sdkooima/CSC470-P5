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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FormLogin loginWindow = new FormLogin();
            
            loginWindow.ShowDialog();
            if (loginWindow.DialogResult == DialogResult.Cancel) Environment.Exit(0);

            FormProject projectSelect = new FormProject();

            projectSelect.ShowDialog();
            if (projectSelect.DialogResult == DialogResult.Cancel) Environment.Exit(0);
            else
            {
                FakePreferenceRepository ReferenceRepo = new FakePreferenceRepository();
                Text = "Main - " + FormProject.selectedProjectName;
                Update();
            }
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateProject createProject = new FormCreateProject();
            createProject.ShowDialog();
            if (createProject.DialogResult == DialogResult.Cancel) createProject.Close();
        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProject projectSelect = new FormProject();
            projectSelect.ShowDialog();

            if (projectSelect.DialogResult == DialogResult.Cancel && projectSelect.numOfSelects == 0) Environment.Exit(0);
            else if (projectSelect.DialogResult == DialogResult.Cancel && projectSelect.numOfSelects != 0) projectSelect.Close();
            else
            {
                FakePreferenceRepository ReferenceRepo = new FakePreferenceRepository();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemoveProject removeProject = new FormRemoveProject();
            removeProject.ShowDialog();

            if (removeProject.DialogResult == DialogResult.Cancel) removeProject.Close();
            else
            {
                FakePreferenceRepository ReferenceRepo = new FakePreferenceRepository();
            }
        }
    }
}
