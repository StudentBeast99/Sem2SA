using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortTools;
using SortDrawTools;

namespace _4
{
    public partial class SortsForm : Form
    {
        public SortsForm()
        {
            InitializeComponent();
        }

        private void BubleSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort(20);
            List<Position> positions = sender == BubleSort ? sort.BubleSort() : sort.ShakerSort();
            SortDraw draw = new SortDraw(Output.Size);
            List<Bitmap> bitmaps = draw.Draw(positions);
            foreach (var item in bitmaps)
            {
                Output.Image = item;
                Refresh();
                Thread.Sleep(400);
            }
        }
    }
}
