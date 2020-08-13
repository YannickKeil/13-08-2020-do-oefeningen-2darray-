using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_08_2020_do_oefeningen__2darray_
{
    public partial class PopUp : Form
    {
        
        public PopUp()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNewName.Text == "")
            {
                tbNewName.Text = " ";
            }
            Close();
        }
        public Oef1Buttons MyParentForm;
        public string NewName
        {
            get { return tbNewName.Text; }
        }

        private void PopUp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbNewName.Text = "";
            Close();
        }
    }
}
