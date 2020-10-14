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
    public partial class FormProject : Form
    {
        //FakeProjectRepository Project_Repo = new FakeProjectRepository();

        public FormProject()
        {
            InitializeComponent();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public int numOfSelects = -1;
        public static string selectedProjectName;

        private void buttonSelect_Click(object sender, EventArgs e)
        {

            if (Projects.SelectedItem != null)
            {
                FakePreferenceRepository PrefRepo = new FakePreferenceRepository();
                Preference Selection = new Preference();

                Selection.UserName = " ";
                string SelectedItem = Projects.SelectedItem.ToString();
                string[] ListedString = SelectedItem.Split('-');
                Selection.Value = ListedString[0].Trim();
                Selection.Name = ListedString[1].Trim();

                PrefRepo.SetPreference(Selection.UserName, Selection.Name, Selection.Value);
                
                selectedProjectName = Selection.Name;
                numOfSelects++;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                //Environment.Exit(0);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormProject_Load(object sender, EventArgs e)
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
