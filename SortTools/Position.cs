using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTools
{
    public class Position
    {
        public List<int> Arr { get; private set; }
        public int SelectIndex1 { get; private set; }
        public int SelectIndex2 { get; private set; }

        public Position(List<int> arr, int selectIndex1, int selectIndex2)
        {
            Arr = arr;
            SelectIndex1 = selectIndex1;
            SelectIndex2 = selectIndex2;
        }
    }
}
