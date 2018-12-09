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
        public bool isRight = false;

        public Answer(string inputText, bool checker)
        {
            isRight = checker;
            text = inputText;
        }
    }
}
