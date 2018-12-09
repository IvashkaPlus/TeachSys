using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    class Teacher
    {
        public string teacherId;
        public string tFirstName;
        public string tLastName;
        public string tEmail;
        public string sciDegree;
        public string tPhoneNumber;
        public string patronym;
        public int subId;

        public Teacher(string tId, string tFN, string tLN, string tE, string SD, string tPN, string pat, int sId)
        {
            teacherId    = tId;
            tFirstName   = tFN;
            tLastName    = tLN;
            tEmail       = tE;
            sciDegree    = SD;
            tPhoneNumber = tPN;
            patronym     = pat;
            subId        = sId;
        }
    }
}
