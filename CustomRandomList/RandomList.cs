using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
             Random random = new (Count);
            int index = random.Next();
            string element = this[index];
            RemoveAt (index);
            return element;
        }
    }
}
