using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue_try1_1401._05._11
{
    internal class Priority_Queue_Class
    {

        public int value { get; private set; }
        public int priority { get; private set; }
        public Priority_Queue_Class (int value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }



    }
}
