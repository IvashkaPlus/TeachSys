using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    public class Answer
    {
        public string text;
        public int isRight = 0;

        public Answer(string inputText, int checker)
        {
            isRight = checker;
            text = inputText;
        }
    }
}
