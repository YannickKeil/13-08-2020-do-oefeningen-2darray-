using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joepie2DArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private int[] rij1 = new int[] { 1, 2, 3 };
        private int[] rij2 = new int[] { 4, 5, 6 };
        private int[] rij3 = new int[] { 7, 8, 9 };

        private int[,] my2DArray = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };*/

        private int[,] myArray = new int[10, 10];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    myArray[i, j] = (i + 1) * (j + 1);
                }
                cbTafel.Items.Add(i + 1);
            }
        }

        private void cbTafel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTafel.Text = "";
            for (int i = 0; i < 10; i++)
            {
                lblTafel.Text += myArray[Convert.ToInt32(cbTafel.SelectedItem) - 1, i].ToString() + " ";
            }
        }
    }
}
