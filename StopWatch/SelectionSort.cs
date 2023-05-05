using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Array
    {
        private int Arr_Size = 100000;
        private int[] arr;
        
        private string _result;
        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public Array()
        {
            StopWatch stopwatch = new StopWatch();
            stopwatch.Start();
            arr = new int[this.Arr_Size];
            Random rand = new Random();
            for (int i=0; i < this.Arr_Size; i++)
            {
                arr[i] = rand.Next();
            }


            for (int i = 0; i < this.Arr_Size -1; i++)
            {
                int minIndex = i;
                for (int j = 1 + 1; j < this.Arr_Size; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            stopwatch.Stop();
            stopwatch.GetElapsedTime();
            this.Result = Convert.ToString(stopwatch.GetElapsedTime());
        }

        public override string ToString()
        {
            return $"Elapsed time: {Result}";
        }
    }
}
