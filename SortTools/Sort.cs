using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTools
{
    public class Sort
    {
        List<Position> positions;
        List<int> Arr;
        Random rnd = new Random();

        public Sort(int N)
        {
            Randomize(N);
        }

        public void Randomize(int N)
        {
            Arr = new List<int>();
            for (int i = 0; i < N; i++)
            {
                Arr.Add(i + 1);
            }
            for (int i = 0; i < N; i++)
            {
                int k = rnd.Next(N);
                int m = rnd.Next(N);
                int t = Arr[k];
                Arr[k] = Arr[m];
                Arr[m] = t;
            }
        }
        public List<Position> BubleSort()
        {
            positions = new List<Position>();
            positions.Add(new Position(new List<int>(Arr), -1, -1));
            for (int i = 0; i < Arr.Count; i++)
            {
                for (int j = 0; j < Arr.Count - i - 1; j++)
                {
                    positions.Add(new Position(new List<int>(Arr), j, j + 1));
                    if (Arr[j] > Arr[j + 1])
                    {
                        int T = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = T;
                        positions.Add(new Position(new List<int>(Arr), j, j + 1));
                    }
                }
            }
            positions.Add(new Position(new List<int>(Arr), -1, -1));
            return positions;
        }
        public List<Position> ShakerSort()
        {
            positions = new List<Position>();
            positions.Add(new Position(new List<int>(Arr), -1, -1));
            int left = 0;
            int right = Arr.Count - 1;
            bool t = true;
            while (left <= right && t)
            {
                t = false;
                for (int i = left; i < right; i++)
                {
                    positions.Add(new Position(new List<int>(Arr), i, i + 1));
                    if (Arr[i] > Arr[i + 1])
                    {
                        int T = Arr[i];
                        Arr[i] = Arr[i + 1];
                        Arr[i + 1] = T;
                        positions.Add(new Position(new List<int>(Arr), i, i + 1));
                        t = true;
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    positions.Add(new Position(new List<int>(Arr), i, i - 1));
                    if (Arr[i - 1] > Arr[i])
                    {
                        int T = Arr[i];
                        Arr[i] = Arr[i - 1];
                        Arr[i - 1] = T;
                        positions.Add(new Position(new List<int>(Arr), i, i - 1));
                        t = true;
                    }
                }
                left++;
            }
            positions.Add(new Position(new List<int>(Arr), -1, -1));
            return positions;
        }
    }
}
