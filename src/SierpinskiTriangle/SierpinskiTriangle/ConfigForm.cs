using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SierpinskiTriangle
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            int numOfRec = (int)NORNumericUpDown.Value; // rekurzió számának lekérdezése
            CanvasForm cf = new CanvasForm(numOfRec);   // új kirajzolós Form létrehozása
            cf.ShowDialog();                            // és megjelenítése
        }
    }
}
