using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare Random Number Generator
        Random randomGenerator = new Random();
        public void GenerateFractalTop(int Level, Graphics g, Point PrevEndPoint, Point PrevStartPoint, Double PreviousAngle, double thickness, int rgbColour)
        {
            if (Level == 0)
            {
                return;
            }
            else
            {
                double Theta1, Theta2, RotateAngle1, RotateAngle2, DesiredLength, LengthRatio;
                double ThicknessIncrement;
                Point NewP1, NewP2, NewP3, NewP4;

                //Point 1 and 2 are for the top shape, point 3 and 4 are for the bottom.
                NewP1 = new Point();
                NewP2 = new Point();
                NewP3 = new Point();
                NewP4 = new Point();

                //(Angle (Level Angle Increment)* 180) / Pi = Radians for both angles. Increase the degree by 5 for every level.
                RotateAngle1 = (55 + (Level*1)) * (Math.PI/180);
                RotateAngle2 = (55 + (Level * 1)) * (Math.PI / 180);

                //Finds the thetas in radians for the top two branching lines (prev angle is in radians)
                Theta1 = PreviousAngle - RotateAngle1;
                Theta2 = PreviousAngle + RotateAngle2;

                //Find the desired length of the new branching lines, which will smaller than the previous lines determined by the division constant.
                DesiredLength = (Math.Sqrt(((PrevEndPoint.X - PrevStartPoint.X) * (PrevEndPoint.X - PrevStartPoint.X)) + ((PrevEndPoint.Y - PrevStartPoint.Y) * (PrevEndPoint.Y - PrevStartPoint.Y))))/1.5;

                //Top branch segment:

                //Determine the x and y values for the first branch. 
                NewP1.X = Convert.ToInt32(PrevEndPoint.X + (Math.Sin(Theta1) * DesiredLength));
                NewP1.Y = Convert.ToInt32(PrevEndPoint.Y - (Math.Cos(Theta1) * DesiredLength));

                //Determine x and y values for the second branch.
                NewP2.X = Convert.ToInt32(PrevEndPoint.X + (Math.Sin(Theta2) * DesiredLength));
                NewP2.Y = Convert.ToInt32(PrevEndPoint.Y - (Math.Cos(Theta2) * DesiredLength));

                /*The lines will get shorter for every level. 
                 * The lines will decrease by 0.2 thickness every level until the thickness
                 * reaches 1, then the thickness will stay at that level. */

                if(thickness == 1)
                {
                    ThicknessIncrement = 0;
                }
                else
                {
                    ThicknessIncrement = 0.2;
                }

                //Create a pen using the colour and thickness and their increments.
                Pen mypen = new Pen(Color.FromArgb(255,0,255,rgbColour), Convert.ToSingle(thickness));

                //Draw the two top new branching
                g.DrawLine(mypen, PrevEndPoint, NewP1);
                g.DrawLine(mypen, PrevEndPoint, NewP2);

                //Draw the line connecting the branching line end points to the previous start point.
                g.DrawLine(mypen, PrevStartPoint, NewP1);
                g.DrawLine(mypen, PrevStartPoint, NewP2);

                //call the function again for each branch with their respective angles and points. 
                GenerateFractalTop(Level - 1, g, NewP1, PrevEndPoint, Theta1, thickness - ThicknessIncrement, rgbColour);
                GenerateFractalTop(Level - 1, g, NewP2, PrevEndPoint, Theta2, thickness - ThicknessIncrement, rgbColour);


                //Bottom branch segment:

                //Determine the x and y values for the first bottom branch.
                NewP3.X = Convert.ToInt32(PrevStartPoint.X + (Math.Sin(Theta1) * DesiredLength));
                NewP3.Y = Convert.ToInt32(PrevStartPoint.Y + (Math.Cos(Theta1) * DesiredLength));

                //Determine x and y values for the second bottom branch.
                NewP4.X = Convert.ToInt32(PrevStartPoint.X + (Math.Sin(Theta2) * DesiredLength));
                NewP4.Y = Convert.ToInt32(PrevStartPoint.Y + (Math.Cos(Theta2) * DesiredLength));

                //Draw the two bottom new branches
                g.DrawLine(mypen, PrevStartPoint, NewP3);
                g.DrawLine(mypen, PrevStartPoint, NewP4);
                
                //Draw the line connecting the branching line end points to the previous start point.
                g.DrawLine(mypen, PrevEndPoint, NewP3);
                g.DrawLine(mypen, PrevEndPoint, NewP4);

                //Call the function again to draw the bottom branches: 
                GenerateFractalTop(Level - 1, g, NewP3, PrevStartPoint, Theta2, thickness - ThicknessIncrement, rgbColour);
                GenerateFractalTop(Level - 1, g, NewP4, PrevStartPoint, Theta1, thickness - ThicknessIncrement, rgbColour);
            }
        }

        public void GenerateFractalBottom(int Level, Graphics g, Point PrevEndPoint, Point PrevStartPoint, Double PreviousAngle, double thickness, int rgbColour)
        {
            if (Level == 0)
            {
                return;
            }
            else
            {
                double Theta1, Theta2, RotateAngle1, RotateAngle2, DesiredLength, LengthRatio;
                double ThicknessIncrement;
                Point NewP1, NewP2;

                NewP1 = new Point();
                NewP2 = new Point();


                RotateAngle1 = 0.785398 + (Level*0.005);
                RotateAngle2 = 0.785398 + (Level*0.005); 

                //Finds the thetas in radians (prev angle is in radians)
                Theta1 = PreviousAngle - RotateAngle1;
                Theta2 = PreviousAngle + RotateAngle2;

                //Find the desired length of the line, half the length of the previous line.
                DesiredLength = (Math.Sqrt(((PrevEndPoint.X - PrevStartPoint.X) * (PrevEndPoint.X - PrevStartPoint.X)) + ((PrevEndPoint.Y - PrevStartPoint.Y) * (PrevEndPoint.Y - PrevStartPoint.Y)))) / 1.5;

                //Determine the x and y values for the first branch.
                NewP1.X = Convert.ToInt32(PrevEndPoint.X + (Math.Sin(Theta1) * DesiredLength));
                NewP1.Y = Convert.ToInt32(PrevEndPoint.Y + (Math.Cos(Theta1) * DesiredLength));

                //Determine x and y values for the second branch.
                NewP2.X = Convert.ToInt32(PrevEndPoint.X + (Math.Sin(Theta2) * DesiredLength));
                NewP2.Y = Convert.ToInt32(PrevEndPoint.Y + (Math.Cos(Theta2) * DesiredLength));

                if (thickness == 1)
                {
                    ThicknessIncrement = 0;
                }
                else
                {
                    ThicknessIncrement = 0.2;
                }
                Pen mypen = new Pen(Color.FromArgb(255, 0, 255, rgbColour), Convert.ToSingle(thickness));

                //Draw the two new branches
                g.DrawLine(mypen, PrevEndPoint, NewP1);
                g.DrawLine(mypen, PrevEndPoint, NewP2);

                //Draw the line connecting to the previous start point.
                g.DrawLine(mypen, PrevStartPoint, NewP1);
                g.DrawLine(mypen, PrevStartPoint, NewP2);

                //call the function again for each branch with their respective angles and points. 
                GenerateFractalBottom(Level - 1, g, NewP1, PrevEndPoint, Theta1, thickness - ThicknessIncrement, rgbColour);
                GenerateFractalBottom(Level - 1, g, NewP2, PrevEndPoint, Theta2, thickness - ThicknessIncrement, rgbColour);

            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int iLevel, rgbColor;
                Point P0, P1;

                if(txtLevel.Text == null)
                {
                    MessageBox.Show("Error, enter a level.");
                    return;
                }
                rgbColor = 0;
                
                iLevel = Convert.ToInt32(txtLevel.Text);

                P0 = new Point();
                P1 = new Point();

                P0.X = 300;
                P0.Y = 225;
                P1.X = 300;
                P1.Y = 375;

                Graphics g = Graphics.FromHwnd(pbFractal.Handle);
                g.Clear(Color.White);

                Pen mypen = new Pen(Color.FromArgb(255, 0, 255, 0), 5);

                g.DrawLine(mypen, P0, P1);

                GenerateFractalTop(iLevel, g, P0, P1, 0, 3, 120);
                //GenerateFractalBottom(iLevel, g, P1, P0, 0, 3, 120);
            }
            catch
            {

            }
        }
    }
}
