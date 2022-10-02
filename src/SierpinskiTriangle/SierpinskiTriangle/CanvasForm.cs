using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SierpinskiTriangle
{
    public partial class CanvasForm : Form
    {
        public CanvasForm(int RecNumber)
        {
            InitializeComponent();
            this.recNumber = RecNumber;
        }
        // új toll létrehozása, sárga (255, 255, 0) színnel és 1.5 pont vastagsággal
        Pen pen = new Pen(Color.FromArgb(255, 255, 0), 1.5f);

        private const int MAX_NUM_OF_THREADS = 3; // max szál szám
        private int numOfThreads = 0;             // szálak jelenlegi száma


        private int recNumber;

        private void CanvasPB_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point a = new Point(CanvasPB.Width / 2, 10);   // felső, középső pont létrehozása
            Point b = new Point(10, CanvasPB.Height - 10); // alsó, bal pont létrehozása
            Point c = new Point(CanvasPB.Width - 10, CanvasPB.Height - 10); // jobb, alsó pont
            
            DrawST(g, a, b, c, recNumber);
        }

        private void DrawST(Graphics g, Point a, Point b, Point c, int depth)
        {
            if (depth < 0) // ha a jelenlegi mélység túl kicsi lenne, akkor csak visszalépek
                return;

            Point[] pArray = { a, b, c }; // pont-tömb létrehozása a kirajzoláshoz

            lock (g) // sokszög kirajzolása a létrehozott tollal és pont-tömbbel
                g.DrawPolygon(pen, pArray);

            // felezőpontok kiszámlálása
            Point Fab = new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2);
            Point Fbc = new Point((b.X + c.X) / 2, (b.Y + c.Y) / 2);
            Point Fac = new Point((a.X + c.X) / 2, (a.Y + c.Y) / 2);
            int newDepth = depth - 1; // új mélység kiszámolása


            // szál létrehozása, ha még lehet elindítani, különben rekurzívan lesz a
            // feladata elvégezve
            Thread t1 = new Thread(() => DrawST(g, a, Fab, Fac, newDepth));
            if (numOfThreads < MAX_NUM_OF_THREADS)
            {
                t1.Start();
                numOfThreads++;
            }
            else
            {
                DrawST(g, a, Fab, Fac, newDepth);
            }

            Thread t2 = new Thread(() => DrawST(g, b, Fab, Fbc, newDepth));
            if (numOfThreads < MAX_NUM_OF_THREADS)
            {
                t2.Start();
                numOfThreads++;
            }
            else
            {
                DrawST(g, b, Fab, Fbc, newDepth);
            }

            Thread t3 = new Thread(() => DrawST(g, c, Fac, Fbc, newDepth));
            if (numOfThreads < MAX_NUM_OF_THREADS)
            {
                t3.Start();
                numOfThreads++;
            }
            else
            {
                DrawST(g, c, Fac, Fbc, newDepth);
            }

            // ha szálak el lettek indítva, akkor visszafűzzük az őt indító szálba
            // és csökkentjük a jelenleg futó szálak számát
            if (t1.ThreadState != ThreadState.Unstarted)
            {
                t1.Join();
                numOfThreads--;
            }
            if (t2.ThreadState != ThreadState.Unstarted)
            {
                t2.Join();
                numOfThreads--;
            }
            if (t3.ThreadState != ThreadState.Unstarted)
            {
                t3.Join();
                numOfThreads--;
            }
        }
    }
}
