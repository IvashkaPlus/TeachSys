using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    public class GradeCriteria
    {
        //public int criteriaId;
        //public int testId;
        public int for5;
        public int for4;
        public int for3;

        public GradeCriteria(int f5, int f4, int f3)
        {
            for5 = f5;
            for4 = f4;
            for3 = f3;
        }
    }
}
