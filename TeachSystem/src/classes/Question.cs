using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachSystem
{
    public class Question
    {
        //public int questionId;
        public string text;
        //public int testId;
        public List<Answer> answers;
        public Question(string inputText)
        {
            text = inputText;
        }
    }
}
