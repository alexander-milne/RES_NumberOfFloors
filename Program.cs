using System;
using System.Collections;

namespace RessApp
{
    class Program
    {
        public static NoOfAssigmentsStore nOAS;

        public static double NumberOfArrangements(double numberOfStories)
        {
            string arranment = "";
            for (double i = 0; i < numberOfStories; i++)
            {
                arranment += "s";
            }

            String[] array = new String[] { arranment };
            nOAS.noOfAssignmentsStore[0] = 0;
            nOAS.noOfAssignmentsStore[1] = 1;
            double val = 1 + noOfOptionsAddingOneLarge(arranment);
            return val;
        }

        public static double noOfOptionsAddingOneLarge(string arranment)
        {
            
            if (nOAS.noOfAssignmentsStore[arranment.Length-1] != -1)
            {
                return nOAS.noOfAssignmentsStore[arranment.Length-1];
            }


            string newArranment = arranment.Substring(2, arranment.Length - 2);
            string newArranment_only_one = arranment.Substring(1, arranment.Length - 1);
            nOAS.noOfAssignmentsStore[arranment.Length-1] = 1 + noOfOptionsAddingOneLarge(newArranment) + noOfOptionsAddingOneLarge(newArranment_only_one);
            return nOAS.noOfAssignmentsStore[arranment.Length-1];



        }

        static void Main(string[] args)
        {
            int numberOfFloors = 1399;
            nOAS = new NoOfAssigmentsStore(numberOfFloors);
            Console.WriteLine(NumberOfArrangements(numberOfFloors));
        }
    }
}
