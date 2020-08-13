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
    public partial class oefening_1 : Form
    {
        public oefening_1()
        {
            InitializeComponent();
        }

        public string[,] newArray = new string[25, 8];
    

        private void oefening_1_Load(object sender, EventArgs e)
        {
            newArray[0, 1] = "Maandag";
            newArray[0, 2] = "Dinsdag";
            newArray[0, 3] = "Woensdag";
            newArray[0, 4] = "Donderdag";
            newArray[0, 5] = "Vrijdag";
            newArray[0, 6] = "Zaterdag";
            newArray[0, 7] = "Zondag";

            for (int i = 0; i < 24; i++)
            {
                newArray[i + 1, 0] = $"{i}:00";
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (i == 0 && j > 0)
                    {
                    }
                    else if (j == 0 && i > 0)
                    {
                    }
                    else
                    {
                        newArray[j, i] = "";
                    }
                    TextBox newTextBox = new TextBox();
                    newTextBox.Width = 80;
                    newTextBox.Height = 40;
                    newTextBox.Text = newArray[j, i];
                    newTextBox.BackColor = Color.White;
                    newTextBox.Name = $"button_{i}_{j}";
                    newTextBox.Location = new Point(10 + newTextBox.Width * i, 10 + newTextBox.Height * j);
                   
                    Controls.Add(newTextBox);
                    if (i == 0 && j >= 0)
                    {
                        newTextBox.Enabled = false;
                    }
                    else if (j == 0 && i >= 0)
                    {
                        newTextBox.Enabled = false;
                    }
                }
            }
            
        }
            





    }
}

