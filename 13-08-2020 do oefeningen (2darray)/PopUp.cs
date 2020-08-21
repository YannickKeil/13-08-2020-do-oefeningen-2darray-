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

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newAppointment = tbNewName.Text;
            this.DialogResult = DialogResult.OK;
        }
        
        public string newAppointment;
        

        private void PopUp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
