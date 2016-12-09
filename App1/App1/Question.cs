using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace App1
{
    public class Question
    {

        public string id;
        public string questiontext;
        public bool answer;

        public Question(string question, bool ans)
        {
            QuestionText = question;
            answer = ans;
        }
        

        
        public string QuestionId
        {
            get { return id; }
            set { id = value; }
        }

        
        public string QuestionText
        {
            get { return questiontext; }
            set { questiontext = value; }
        }

        
        public bool Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
