using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortTools;
using System.Drawing;

namespace SortDrawTools
{
    public class SortDraw
    {
        List<Position> positions;
        List<Bitmap> bitmaps;
        public Size Size { get; set; }

        public SortDraw(Size size)
        {
            this.Size = size;
        }
        private void DrawPosition(Position pos)
        {
            Bitmap image = new Bitmap(Size.Width, Size.Height);
            Graphics G = Graphics.FromImage(image);
            int Y = Size.Height / 2 - 50;
            int X = (Size.Width - 30) / (pos.Arr.Count);
            for (int i = 0; i < pos.Arr.Count; i++)
            {
                    G.DrawString(pos.Arr[i].ToString(), new Font("Microsoft Sans", 15), (pos.SelectIndex1 == i|| pos.SelectIndex2 == i)? Brushes.Red:Brushes.Black, X * i + 15, Y);
            }
            G.Dispose();
            bitmaps.Add(image);
        }
        public List<Bitmap> Draw(List<Position> positions)
        {
            bitmaps = new List<Bitmap>();
            foreach (var item in positions)
            {
                DrawPosition(item);
            }
            return bitmaps;
        }
    }
}
