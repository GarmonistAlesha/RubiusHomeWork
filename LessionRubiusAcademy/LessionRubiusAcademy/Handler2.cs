using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessionRubiusAcademy
{
    public class Handler2
    {
        public void HandleThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("Уже 77, давно пора было начать!");
        }
    }

    class Program
    {
        static void Main()
        {
            Counter counter = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            counter.ThresholdReached += handler1.HandleThresholdReached;
            counter.ThresholdReached += handler2.HandleThresholdReached;

            counter.CountTo100();
        }
    }
}
