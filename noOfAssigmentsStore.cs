using System;
using System.Collections.Generic;
using System.Text;

namespace RessApp
{
    class NoOfAssigmentsStore
    {
        public double[] noOfAssignmentsStore;

        public NoOfAssigmentsStore(int size)
        {
            if (size < 2)
            {
                size = 2;
            }
            noOfAssignmentsStore = new double[size];
            
            for (var i = 0; i < size; i++)
            {
                noOfAssignmentsStore[i] = -1;
            }
        }
    }
}
