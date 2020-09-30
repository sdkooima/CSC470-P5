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
        }
    }
}
