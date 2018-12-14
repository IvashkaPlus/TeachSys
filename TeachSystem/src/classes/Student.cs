using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    class Student
    {
        public string studentId;
        public string sFirstName;
        public string sLastName;
        public string sEmail;
        public int sGroupId;

        public Student(string sId, string sFN, string sLN, string sE, int sGId)
        {
            studentId  = sId;
            sFirstName = sFN;
            sLastName  = sLN;
            sEmail     = sE;
            sGroupId   = sGId;
    }
    }
}
