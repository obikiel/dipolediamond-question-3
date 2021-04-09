using System;

namespace second_task
{
     class Program
    {

        public static int maximum_const(int[] array)
        {
            int maxcount = 0;
            int tempcount = 0;

            bool orderTracker = false;
            bool countedValue = false;

            for (int i=0; i< array.Length; i++)
            {
                if (orderTracker)
                {
                    if (array[i] == 1)
                    {
                        tempcount = tempcount + 1;
                        countedValue = true;
                    }
                    else
                    {
                        maxcount = tempcount > maxcount ? tempcount : maxcount;
                        countedValue = false;
                        tempcount = 0;
                    }
                }
                else
                {
                    countedValue = false;
                }

                if(array[i] == 1 && countedValue == false)
                {
                    tempcount = tempcount + 1;
                    orderTracker = true;
                }
               

            }

            return maxcount;
        }
        static void Main(string[] args)
        {
                Console.ReadLine   maximum_const([]);
        }
    }
}