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
    public partial class Oef1Buttons : Form
    {
        public Oef1Buttons()
        {
            InitializeComponent();
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            PopUp pu = new PopUp();
            pu.MyParentForm = this;
            pu.ShowDialog();
            if (pu.NewName !="")
            {
                (sender as Button).Text = pu.NewName;
            }
            
            

        }
        public string[,] newArray = new string[25, 8];
        private void Oef1Buttons_Load(object sender, EventArgs e)
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
                    //TextBox newTextBox = new TextBox();
                    //newTextBox.Width = 80;
                    //newTextBox.Height = 40;
                    //newTextBox.Text = newArray[j, i];
                    //newTextBox.BackColor = Color.White;
                    //newTextBox.Name = $"button_{i}_{j}";
                    //newTextBox.Location = new Point(10 + newTextBox.Width * i, 10 + newTextBox.Height * j);
                    Button newButton = new Button();
                    newButton.Width = 80;
                    newButton.Height = 40;
                    newButton.Text = newArray[j, i];
                    newButton.BackColor = Color.White;
                    newButton.Name = $"button_{i}_{j}";
                    newButton.Location = new Point(10 + newButton.Width * i, 10 + newButton.Height * j);
                    
                    newButton.Click += new EventHandler(newButton_Click);
                    Controls.Add(newButton);

                    //Controls.Add(newTextBox);
                    if (i == 0 && j >= 0)
                    {
                        newButton.Enabled = false;
                    }
                    else if (j == 0 && i >= 0)
                    {
                        newButton.Enabled = false;
                    }
                }
            }
        }
    }
}
