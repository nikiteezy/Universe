using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universe
{
    public partial class Form1 : Form
    {
        StartUniverse start = new StartUniverse();

        #region start functions
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCanvas();
    
            start.CreationOfLife();

            DrawingStartPositions();
        }
        
        void CreateCanvas()
        {
            int yPos = 0;
            int xPos = 0;

            int yInc = 10;
            int xInc = 10;
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Label lbl = new Label()
                    {
                        Name = ("lbl" + i + "." + j),
                        BackColor = Color.Aqua,
                        Width = 10,
                        Height = 10
                    };

                    if (j == 0)
                    {
                        xPos = 0;
                        yPos += yInc;
                    }
                    else
                        xPos += xInc;

                    lbl.Location = new Point(xPos, yPos);
                    this.Controls.Add(lbl);
                }
            }
        }

        void DrawingStartPositions()
        {
            for (int i = 0; i < start.countCell; i++)
            {
                MoveDrawing(start.cell[i].xPos, start.cell[i].yPos, start.cell[i].xPos, start.cell[i].yPos);
            }
        }
        #endregion

        public void MoveDrawing(int _x, int _y, int x, int y)
        {
            this.Controls["lbl" + _x + "." + _y].BackColor = Color.Aqua;
            this.Controls["lbl" + x + "." + y].BackColor = Color.Green; 
        }
    }
}