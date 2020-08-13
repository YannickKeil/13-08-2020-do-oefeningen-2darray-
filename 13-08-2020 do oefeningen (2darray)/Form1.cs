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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnOef1_Click(object sender, EventArgs e)
        {
            oefening_1 oef = new oefening_1();
            oef.Show();
        }

        private void btnOef1Btns_Click(object sender, EventArgs e)
        {
            Oef1Buttons oef = new Oef1Buttons();
            oef.Show();
        }

    }
}
