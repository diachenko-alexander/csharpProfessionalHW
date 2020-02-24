using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proffesionalHW1
{
    class Program
    {
        //With yield
        public IEnumerable<int> SomeMethod (int [] array)
        {
            var result = array.Where(e => e % 2 != 0);
            foreach (var item in result)
            {
                yield return item * item;
            }
        }
        // Without 
        public IEnumerable<int> SomeMethod2(int[] array)
        {
            return array.Where(e => e % 2 != 0).Select(e => e * e);
        }

        static void Main(string[] args)
        {
            
        }
    }
}
