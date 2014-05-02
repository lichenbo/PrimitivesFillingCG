using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PrimitivesFillingCG
{
    public partial class CanvasForm : Form
    {
        class Line
        {
            public Point from;
            public Point to;

            public Line(Point from, Point to)
            {
                this.from = from;
                this.to = to;
            }
        }
        class EDGE
        {
            public int maxY;
            public int lowerX;
            public double inverseM;

            public EDGE(int maxY, int lowerX, double inverseM)
            {
                this.maxY = maxY;
                this.lowerX = lowerX;
                this.inverseM = inverseM;
            }
        }
        Bitmap originbmp;
        public CanvasForm(int width, int height)
        {
            InitializeComponent();
            originbmp = new Bitmap(width, height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            Bitmap bmp = new Bitmap(originbmp);
            List<Line> lines = new List<Line>();
            foreach(string line in txtPoints.Lines)
            {
                string[] strLine = line.Split('-');
                string[] strfrom = strLine[0].Split(',');
                string[] strto = strLine[1].Split(',');
                Point fromPoint = new Point(Convert.ToInt32(strfrom[0]), Convert.ToInt32(strfrom[1]));
                Point toPoint = new Point(Convert.ToInt32(strto[0]), Convert.ToInt32(strto[1]));
                lines.Add(new Line(fromPoint, toPoint));
            }

            stopwatch.Start();
            if (radioScan.Checked)
            {
                // init the array
                List<EDGE>[] listedgeArray = new List<EDGE>[originbmp.Height];
                for (int i = 0; i < listedgeArray.Length; i++)
                {
                    listedgeArray[i] = new List<EDGE>();
                }

                // preprocess
                for (int i = 0; i < lines.Count; i++)
                {
                    Line curLine = lines[i];
                    Line prevLine;
                    if (i == 0)
                        prevLine = lines[lines.Count - 1];
                    else
                        prevLine = lines[i - 1];

                    if (prevLine.from.Y < curLine.from.Y && curLine.from.Y < curLine.to.Y)
                        prevLine.to.Y--;
                    if (prevLine.from.Y > curLine.from.Y && curLine.from.Y > curLine.to.Y)
                        curLine.from.Y--;
                }
                foreach (Line l in lines)
                {
                    int maxY = (l.from.Y > l.to.Y) ? l.from.Y : l.to.Y;
                    int lowerX = (l.from.Y < l.to.Y) ? l.from.X : l.to.X;
                    double inverseM = (l.to.X - l.from.X) * 1.0 / (l.to.Y - l.from.Y);
                    int minY = (l.from.Y < l.to.Y) ? l.from.Y : l.to.Y;
                    listedgeArray[minY].Add(new EDGE(maxY, lowerX, inverseM));
                }

                // sort
                foreach (List<EDGE> listOfEdge in listedgeArray)
                {
                    listOfEdge.Sort((x, y) => x.lowerX.CompareTo(y.lowerX));
                }

                for (int i = 0; i < listedgeArray.Length; i++)
                {
                    List<EDGE> drawList = listedgeArray[i]; //活化边表
                    List<int> intersectionX = drawList.Select(edge => edge.lowerX).ToList();
                    for (int j = 0; j < i; j++)
                    {
                        if (listedgeArray[j].Count != 0)
                        {
                            List<EDGE> newEdgeList = listedgeArray[j].Where(edge => edge.maxY >= i).ToList();
                            intersectionX.AddRange(newEdgeList.Select(edge => (int)Math.Round(edge.lowerX + edge.inverseM * (i - j))));
                        }
                    }
                    intersectionX.Sort();
                    //foreach (int m in intersectionX)
                    //{
                    //    txtIntersection.Text += (m + ",");
                    //}
                    //txtIntersection.Text += ".\n";
                    for (int k = 0; k < intersectionX.Count / 2; k++)
                    {
                        for (int p = intersectionX[2 * k]; p < intersectionX[2 * k + 1]; p++)
                        {
                            bmp.SetPixel(p, i, Color.Black);
                        }
                    }
                }
            }
            else
                // Recursive Filling
            {
                Pen blackPen = new Pen(Color.Black);
                Graphics g = Graphics.FromImage(bmp);
                foreach (Line l in lines)
                {
                    g.DrawLine(blackPen, l.from, l.to);
                }
                RecFilling(new Point(bmp.Width/2,bmp.Height/2),bmp);
            }
            stopwatch.Stop();
            picbox.Image = bmp;
            txtTime.Text = "Time: " + stopwatch.Elapsed.TotalSeconds;
        }

        void RecFilling(Point seed, Bitmap bmp)
        {
            if (seed.X < bmp.Width-1 && seed.Y < bmp.Height-1 && seed.X > 0 && seed.Y > 0)
            {
                bmp.SetPixel(seed.X, seed.Y, Color.FromArgb(-16777216));
                if (bmp.GetPixel(seed.X + 1, seed.Y).ToArgb() != -16777216)
                    RecFilling(new Point(seed.X + 1, seed.Y), bmp);
                if (bmp.GetPixel(seed.X - 1, seed.Y).ToArgb() != -16777216)
                    RecFilling(new Point(seed.X - 1, seed.Y), bmp);
                if (bmp.GetPixel(seed.X, seed.Y + 1).ToArgb() != -16777216)
                    RecFilling(new Point(seed.X, seed.Y + 1), bmp);
                if (bmp.GetPixel(seed.X, seed.Y - 1).ToArgb() != -16777216)
                    RecFilling(new Point(seed.X, seed.Y - 1), bmp);
            }
        }
    }
}
