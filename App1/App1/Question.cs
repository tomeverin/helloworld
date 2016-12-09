using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Question
    {
        
        public string QuestionText { get; set; }
        public bool Answer { get; set; }

        public Question(string question, bool answer)
        {
            QuestionText = question;
            Answer = answer;
        }
    }
}
