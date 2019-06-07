/*Traveling.cs
Author: Vladislav Dubrovenski
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Ksu.Cis300.Drawing;

namespace Ksu.Cis300.Traveling
{
    public partial class Traveling : Form
    {
        public Traveling()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Optional method to backtrack
        /// </summary>
        /// <param name="stackWithPath">Stack with path</param>
        /// <param name="somethingInPath">stack with booleand that checks if there is something in the path</param>
        /// <param name="distancesBetweenPoints">the distance between points</param>
        /// <param name="currentPathLength">current tour length</param>
        /// <returns></returns>
        private int Backtrack(Stack<int> stackWithPath, bool[] somethingInPath, double[,] distancesBetweenPoints, ref double currentPathLength)
        {
            int currentPoint = stackWithPath.Pop();//popping the top element from the stack
            somethingInPath[currentPoint] = false; //setting the array entry corresponding to the point we popped
            currentPathLength -= distancesBetweenPoints[currentPoint, stackWithPath.Peek()];
            int nextPoint = currentPoint + 1;
            return nextPoint;
        }
        /// <summary>
        /// Calculate the distance between two points
        /// </summary>
        /// <param name="point"> Takes array of points </param>
        /// <returns>distance between 2 point</returns>      
        private double[,] Distance(Point[] point)     
            {
            double [,]d = new double[point.Length, point.Length];
            for (int x = 0; x < point.Length; x++)
            {
                for (int y = 0; y < point.Length; y++)
                {
                    double x1 = point[x].X;
                    double y1 = point[x].Y;
                    double x2 = point[y].X;
                    double y2 = point[y].Y;
                   
                    d[x, y] = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1)*(y2 - y1)));                  
                }
            }
            return d;
            }
        /// <summary>
        /// Adding points to the ListBox, drawing the lines between the points, displaying the MessageBox giving the tour length
        /// </summary>
        /// <param name="pointsOfTour"> Points</param>
        /// <param name="orderOfPoints">Order of points</param>
        /// <param name="length">optimal length</param>      
        private void Display(Point[] pointsOfTour, int[] orderOfPoints, double length)
        {
            int j = 0;
           
            for (int i = 0; i < pointsOfTour.Length-1 ; i++)
            {
                uxDrawingPanel.DrawLine(pointsOfTour[orderOfPoints[i]], pointsOfTour[orderOfPoints[i + 1]]);
                j = i;

                uxListBox.Items.Add(pointsOfTour[orderOfPoints[i]]);            
            }     
            uxDrawingPanel.DrawLine(pointsOfTour[orderOfPoints[j+1]], pointsOfTour[orderOfPoints[0]]);
            uxListBox.Items.Add(pointsOfTour[orderOfPoints[j+1]]);
            uxListBox.Items.Add(pointsOfTour[orderOfPoints[0]]);
            MessageBox.Show("Tour length: " + length);
        }
        /// <summary>
        /// giving the length of the tour found implementing backtracking
        /// </summary>
        /// <param name="numberOfPoints">number of points</param>
        /// <param name="distances">giving the distances between each pair of points</param>
        /// <param name="minLength">store the minimum-length tour.</param>
        /// <returns></returns>
        private double MinimumLength(int numberOfPoints, double[,] distances, int[] minLength)
        {
            bool[] inPath = new bool[numberOfPoints];//checks if points are in the path
            Stack<int> path = new Stack<int>();//stores the path
            int currentPoint = 1;//current point
            path.Push(0); //initializing the stack to 0 
            double currTourLength = 0;//minimum tour length that we've found so far
            double minPath = Double.PositiveInfinity;//min tour length
          
            while (currentPoint < numberOfPoints || path.Count > 1)
            {
                if(numberOfPoints == path.Count) 
                {                  
                    if (minPath > currTourLength + distances[path.Peek(), 0])
                    {
                        minPath = currTourLength + distances[path.Peek(), 0];
                        path.CopyTo(minLength,0);
                    }
                    currentPoint = Backtrack(path, inPath, distances, ref currTourLength);
                }
               else if (currentPoint >= numberOfPoints) 
                {
                    currentPoint = Backtrack(path, inPath, distances,ref currTourLength);
                }
                else if (inPath[currentPoint] == true)  
                {
                    currentPoint++;
                }
                else 
                {
                     currTourLength+=distances[path.Peek(), currentPoint];
                    path.Push(currentPoint);
                    inPath[currentPoint] = true;
                    currentPoint = 1;
                }
            }
            return minPath;
        }      
        /// <summary>
        /// Finds the tour distance, draws lines, points, adds points to the listbox, after it's clicked. Also, displays a message if less than 2 points are clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFindTour_Click(object sender, EventArgs e)
        {           
            double finalDistance = 0;
            Point[] points =  uxDrawingPanel.Points;
            int numberOfPoints;
            double[,] distance;
            int[] minLengthArray;
            double min;
            uxListBox.ResetText();
            uxDrawingPanel.ClearLines();

            if (points.Length < 2)
            {
                MessageBox.Show("Plot 2 or more points");
                return;
            }

            numberOfPoints = points.Length;
            distance = Distance(points);
            minLengthArray = new int[numberOfPoints];
            min =  MinimumLength(numberOfPoints, distance, minLengthArray);
            finalDistance = MinimumLength(numberOfPoints, distance, minLengthArray);           
            Display(points, minLengthArray, finalDistance);           
        }           
        private void uxClear_Click(object sender, EventArgs e)
        {
            uxListBox.ResetText();
            uxListBox.Items.Clear();
            uxDrawingPanel.Clear();
            uxDrawingPanel.ClearLines();
        }
        private void Traveling_Load(object sender, EventArgs e)
        {

        }
        private void uxListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void uxDrawingPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
