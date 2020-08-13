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
    public partial class MagischVierkant : Form
    {
        public MagischVierkant()
        {
            InitializeComponent();
        }

        

        public int[,] mijnArray = new int[3, 3]
        {
            {4, 9, 2},
            {3, 5, 7},
            {8, 1, 6}
        };
        private void newButton_Click(object sender, EventArgs e)
        {
            double getal = Math.Pow(Convert.ToInt32((sender as Button).Text),2);
            MessageBox.Show(getal.ToString());
        }

        private void MagischVierkant_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button newButton = new Button();
                    newButton.Width = 40;
                    newButton.Height = 40;
                    newButton.Text = mijnArray[i, j].ToString();
                    newButton.Name = $"button_{i}_{j}";
                    newButton.Location = new Point(10+newButton.Width*i, 10 + newButton.Width * j);
                    newButton.Click += new EventHandler(newButton_Click);
                    Controls.Add(newButton);
                }
            }

            //GEEF DE WAARDE VAN JE MAGISCH VIERKANT
            int som = 0;
            for (int i = 0; i < 3; i++)
            {
                som += mijnArray[0, i];
            }

            bool correct = true;

            //HORIZONTAAL EN VERTICAAL
            for (int i = 0; i < 3; i++)
            {
                int checkSomH = 0;
                int checkSomV = 0;

                for (int j = 0; j < 3; j++)
                {
                    checkSomH += mijnArray[i, j];
                    checkSomV += mijnArray[j, i];
                }

                if (checkSomV != som || checkSomH != som)
                {
                    correct = false;
                    break;
                }
            }

            //DIAGONALEN
            int checkSomD1 = 0;
            int checkSomD2 = 0;

            for (int i = 0; i < 3; i++)
            {
                checkSomD1 += mijnArray[i, i];
                checkSomD2 += mijnArray[2 - i, i];                
            }

            if (checkSomD1 != som || checkSomD2 != som)
            {
                correct = false;
            }


            MessageBox.Show(som.ToString());
            if (correct)
                MessageBox.Show("Magisch vierkant!");
            else
                MessageBox.Show("Geen magisch vierkant!");
        }
    }
}
