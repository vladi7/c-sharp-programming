/* UserInterface.cs
 * Author: Vladislav Dubrovenski
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


namespace Ksu.Cis300.TravelingSalesperson
{
    /// <summary>
    /// A GUI for a program that solves the Traveling Salesperson Problem
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles a Clear event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClear_Click(object sender, EventArgs e)
        {
            uxPanel.Clear();
            uxTourPoints.Items.Clear();
        }
        /// <summary>
        /// Handles a Find Tour event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFindTour_Click(object sender, EventArgs e)
        {
            Point[] points = uxPanel.Points;

            uxTourPoints.Items.Clear();
            uxPanel.ClearLines();
            if (points.Length < 2)
            {
                MessageBox.Show("You must plot at least 2 points.");
                return;
            }

            double[,] distances = GetDistances(points);
            int[] tour = new int[points.Length];
            int n = points.Length;
            bool[] visited = new bool[n];
            visited[0] = true;
            LinkedListCell<int> cell = new LinkedListCell<int>();
            double minTour = OptimalLength(0, 0, visited,1,distances, Double.PositiveInfinity, out cell);
            DisplayResults(points, cell, minTour);
        }
        /// <summary>
        /// Displays the minimum tour information.
        /// </summary>
        /// <param name="points">The given points.</param>
        /// <param name="tour">The indices of a minimum-length tour, in order, in the linklist.</param>
        /// <param name="tourLen">The length of a shortest tour.</param>
        private void DisplayResults(Point[] points, LinkedListCell<int> cell, double tourLen)
        {
            uxTourPoints.Items.Add(points[cell.Data]);
            LinkedListCell<int> temp = cell;
            while (temp.Next != null)
            {               
                uxPanel.DrawLine(points[temp.Data], points[temp.Next.Data]);
                uxTourPoints.Items.Add(points[temp.Next.Data]);
                temp = temp.Next;
            }
            uxPanel.DrawLine(points[temp.Data], points[cell.Data]);
            
            uxTourPoints.Items.Add(points[cell.Data]);
            MessageBox.Show("Tour length: " + tourLen);
        }
        /// <summary>
        /// Produces an array of distances between the given points.
        /// </summary>
        /// <param name="points">The points between which the distances are needed.</param>
        /// <returns>An array such that element [i,j] gives the distance from points[i] to points[j].</returns>
        private double[,] GetDistances(Point[] points)
        {
            double[,] distances = new double[points.Length, points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    double xDiff = points[i].X - points[j].X;
                    double yDiff = points[i].Y - points[j].Y;
                    distances[i, j] = Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
                }
            }
            return distances;
        }
        /// <summary>
        /// Finds the minimum-length tour.
        /// </summary>
        /// <param name="curPoint">index of current point in current tour</param>
        /// <param name="pathLenToCur">distance traveled from start to current point along the current path</param>
        /// <param name="visited">marks which points have been visited in the current path visited</param>
        /// <param name="pointsInCurPath">distances between all pairs of points</param>
        /// <param name="distances">how many points are already in the current path</param>
        /// <param name="minTour">shortest tour distance found so far</param>
        /// <param name="bestTourFinish">stores the best tour in the LinkList</param>
        /// <returns></returns>
        private double OptimalLength(int curPoint, double pathLenToCur, bool[] visited, int pointsInCurPath, double[,] distances, double minTour, out LinkedListCell<int> bestTourFinish)
        {
            if (minTour <= pathLenToCur)
            {
                bestTourFinish = null;
                return pathLenToCur;
            }
            if (pointsInCurPath == visited.Length)
            {
                bestTourFinish = new LinkedListCell<int>();
                bestTourFinish.Data = curPoint;
               return pathLenToCur + distances[curPoint,0];
            }
            LinkedListCell<int> temp = new LinkedListCell<int>();
            for(int i = 0; i < visited.Length; i++ )
            {
                if (visited[i] == false)
                {
                    visited[i] = true;
                    double curr = OptimalLength(i, (pathLenToCur + distances[i, curPoint]), visited, pointsInCurPath + 1, distances, minTour, out bestTourFinish);
                    if (curr < minTour)
                    {
                        minTour = curr;
                        temp = bestTourFinish;
                    }
                visited[i] = false;
                }                   
            }
            LinkedListCell<int> cell = new LinkedListCell<int>();
            cell.Data = curPoint;
            cell.Next = temp;
            bestTourFinish = cell;
            return minTour;
        }
    }
}
