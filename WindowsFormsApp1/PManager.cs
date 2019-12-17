using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PManager : Form
    {
        public PManager()
        {
            InitializeComponent();
        }

        private void InfoAboutGoods(object sender, EventArgs e)
        {
            Info newForm = new Info();
            newForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NewItem newForm = new NewItem();
            newForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            StateManager newForm = new StateManager();
            newForm.Show();
        }
    }
}
