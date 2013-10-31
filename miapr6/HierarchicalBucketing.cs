using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace miapr6
{
    class HierarchicalBucketing
    {
        public enum Criterion  {min,max};
        public byte[,] Distances;
        private byte[] Groups;
        private double[,] groupsPosition;
        private byte countGroup;
        private int numberObjects;
        private Chart drawChart;
        private Color[] colArray = { Color.Violet, Color.RosyBrown, Color.Green, Color.Gold,Color.DarkMagenta,Color.Bisque,Color.Red,Color.Blue };
        private int criterionI = 0,criterionJ = 0;

        public HierarchicalBucketing(int numberObjects,object sender)
        {
            this.numberObjects = numberObjects;
            Distances = new byte[numberObjects,numberObjects];
            Groups = new byte[numberObjects];
            groupsPosition = new double[numberObjects*3,2];
            countGroup = 0;
            drawChart = (sender as Chart);
        }

        public void Classification(Criterion criterion)
        {
            double xfirstPoint, yfirstPoint, xlastPoint, ylastPoint;
            int resCriterion;
            int countObjects = 0;
            GenerateDistances();
            while (!IsSingleGroup())
            {
                resCriterion = (criterion == Criterion.min) ? FindMin() : FindMax();
                if (resCriterion  != -1)
                {
                    ++countGroup;
                    
                    if (Groups[criterionI] == 0)
                    {
                        ++countObjects;
                        xfirstPoint = countObjects;
                        yfirstPoint = 0;
                    }
                    else
                    {
                        xfirstPoint = groupsPosition[Groups[criterionI] - 1, 0];
                        yfirstPoint = groupsPosition[Groups[criterionI] - 1, 1];
                    }

                    if (Groups[criterionJ] == 0)
                    {
                        ++countObjects;
                        xlastPoint = countObjects;
                        ylastPoint = 0;
                    }
                    else
                    {
                        xlastPoint = groupsPosition[Groups[criterionJ] - 1, 0];
                        ylastPoint = groupsPosition[Groups[criterionJ] - 1, 1];
                    }

                    ChangeGroup(criterionI);
                    ChangeGroup(criterionJ);
                    groupsPosition[countGroup - 1, 0] = (xfirstPoint + xlastPoint) / (double)2;
                    groupsPosition[countGroup - 1, 1] = resCriterion;

                    Draw(xfirstPoint, yfirstPoint, xlastPoint,ylastPoint, resCriterion);
                    drawChart.Series["Series" + countGroup].LegendText = "without " + (criterionI + 1) + " and " + (criterionJ + 1);
                }
            }
        }

        private int FindMax()
        {
            int max = -1, maxI = 0, maxJ = 0;
            
            for (int i = 0; i < numberObjects; ++i)
                for (int j = i + 1; j < numberObjects; ++j)
                    if (Groups[i] == 0 || Groups[j] == 0 || (Groups[i] != Groups[j]))
                        if (Distances[i, j] > max || max < 0)
                        {
                            max = Distances[i, j];
                            maxI = i;
                            maxJ = j;
                        }
            criterionI = maxI;
            criterionJ = maxJ;
            return max;
        }

        private int FindMin()
        {
            int min = -1,minI = 0, minJ = 0;
            for (int i = 0; i < numberObjects; ++i)
                for (int j = i + 1; j < numberObjects; ++j)
                    if (Groups[i] == 0 || Groups[j] == 0 || (Groups[i] != Groups[j]))
                        if (Distances[i, j] < min || min < 0)
                        {
                            min = Distances[i, j];
                            minI = i;
                            minJ = j;
                        }
            criterionI = minI;
            criterionJ = minJ;
            return min;
        }

        private void Draw(double xfirstPoint, double yfirstPoint, double xlastPoint, double ylastPoint, int min)
        {
            string temp = "Series" + countGroup;
            Random rand = new Random();
            drawChart.Series.Add(temp);
            drawChart.Series[temp].ChartType = SeriesChartType.Line;
            drawChart.Series[temp].BorderWidth = 3;
            drawChart.Series[temp].Color = colArray[countGroup - 1];
            
            drawChart.Series[temp].Points.AddXY(xfirstPoint, yfirstPoint);
            drawChart.Series[temp].Points.AddXY(xfirstPoint, min);
            drawChart.Series[temp].Points.AddXY(xlastPoint, min);
            drawChart.Series[temp].Points.AddXY(xlastPoint, ylastPoint);
        }

        private void ChangeGroup(int number)
        {
            if(Groups[number] != 0)
                for (int i = 0; i < numberObjects; ++i)
                    if ((i != number) && (Groups[i] == Groups[number]))
                        Groups[i] = countGroup;
            Groups[number] = countGroup;
        }

        private void GenerateDistances()
        {
            Random rand = new Random();
            for (int i = 0; i < numberObjects; ++i)
                for (int j = 0; j <= i; ++j)
                    if (i == j)
                        Distances[i, j] = 0;
                    else
                        Distances[i, j] = Distances[j,i] = (byte)rand.Next(1,10);
        }

        bool IsSingleGroup()
        {
            bool result = true;
            for (int i = 1; i < numberObjects; ++i)
                if ((Groups[i] != Groups[i - 1]) || (Groups[i - 1] == 0))
                {
                    result = false;
                    break;
                }
            return result;
        }
    }
}
