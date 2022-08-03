using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue_try1_1401._05._11
{
    public class prior_queue
    {
        Priority_Queue_Class[] QueueArray;
        int Rear = -1;
        public bool Isfull()
        {
            if (Rear == QueueArray.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Isempty()
        {
            if (Rear == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Enqueue(int value, int priority)
        {
            if (!Isfull())
            {
                Priority_Queue_Class Queue_En = new Priority_Queue_Class(value, priority);
                Rear++;
                QueueArray[Rear] = Queue_En;

            }
            else
            {
                Console.WriteLine("Array is full!...");
            }
        }
        public void Dequeue()
        {
            if (!Isempty())
            {
                int MIN = 0;
                for (int i = 0; i < Rear; i++)
                {
                    if (QueueArray[i].priority >= QueueArray[i + 1].priority)
                    {
                        MIN = i + 1;
                    }

                }
                string ITEM = "DeQueue item" + QueueArray[MIN].value + "***" + QueueArray[MIN].priority;
                Console.WriteLine(ITEM);
                QueueArray[MIN] = QueueArray[Rear];
                Rear--;
            }
            else
            {
                Console.WriteLine("Array is empty!...");

            }

        }
        //public void DeQueue()
        //{
        //    if (!Isempty())
        //    {
        //        int DeItemIndex = 0;
        //        for (int i = 0; i < Rear - 1; i++)
        //        {
        //            if (QueueArray[i].priority >= QueueArray[i + 1].priority)
        //            {
        //                DeItemIndex = i+ 1;
        //            }
        //        }
        //        string MinItem = "Dequeue item :" + QueueArray[DeItemIndex].value + "****" + QueueArray[DeItemIndex].priority;
        //        Console.WriteLine(MinItem);
        //        for (int i = DeItemIndex; i < Rear - 1; i++)
        //        {
        //            QueueArray[i] = QueueArray[i + 1];
        //        }
        //        Rear--;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Table is empty!...");
        //    }


        //}


        public void Print_number()
        {
            if (!Isempty())
            {
                for (int i = 0; i < Rear; i++)
                {
                    string Print = $"value items in table : {QueueArray[i].value} and priority : {QueueArray[i].priority} ";
                    Console.WriteLine(Print);
                }
                    
            }
            else
            {
                Console.WriteLine("table is empty!...");
            }
        }
    }

    
}
