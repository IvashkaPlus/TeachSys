using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    public class ReportTeach
    {
        public string subjectTitle;
        public string groupName;
        public double avgGrade;

        public ReportTeach(string sT, string gN, double aG)
        {
            subjectTitle = sT;
            groupName    = gN;
            avgGrade     = aG;
        }
    }
}
