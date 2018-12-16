using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    public class ReportStud
    {
        public string lastName;
        public string testTitle;
        public int grade;

        public ReportStud(string LN, string TT, int g)
        {
            lastName = LN;
            testTitle = TT;
            grade = g;
        }
    }
}
