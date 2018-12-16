using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    class StringEditor
    {
        public static String SpaceDeliting(string str)
        {
            StringBuilder tempName = new StringBuilder(str);
            int checkerSpace = 0;
            int delIndex = 0;
            for (int i = 0; i < tempName.Length; i++)
            {
                char tru = tempName[i];
                if (tempName[i].Equals(' '))
                {
                    checkerSpace++;
                    delIndex = i;
                }
                else
                {
                    checkerSpace = 0;
                }
                if (checkerSpace == 2)
                {
                    tempName.Replace(" ", string.Empty, delIndex - 1, tempName.Length - delIndex + 1);
                    break;
                }
            }
            return tempName.ToString();
        }

    }
}
