using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSessions
{
    public class LenaSorting: IPracticeClass
    {

        public void Execute()
        {
            int q= Convert.ToInt32(Console.ReadLine().Trim());

            for (int qltr = 0; qltr < q; qltr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int l = Convert.ToInt32(firstMultipleInput[0]);
                int c = Convert.ToInt32(firstMultipleInput[1]); 

                //Write your code here
            }    
        }

    }
}
