using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    public class Answer
    {
        //public int answerId;
        public string text;
        //public int questionId;
        public int isRight = 0;

        public Answer(string inputText, int checker)
        {
            isRight = checker;
            text = inputText;
        }
    }
}
