using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Quiz
    {
        public Question[] QuestionSet { get; private set; } = {
            new Question("The sky is red.", false),
            new Question("Cows say 'moo'", true),
            new Question("It is healthy to eat a block of cheese everyday",false)};
        public int CurrentQuestionIndex { get; private set; } = 0;

        public Quiz()
        {

        }

        public Question GetCurrentQuestion()
        {
            return QuestionSet[CurrentQuestionIndex];
        }

        public void SelectNextQuestion()
        {
            if (HasMoreQuestions())
                CurrentQuestionIndex++;
        }

        public bool HasMoreQuestions()
        {
            return (QuestionSet.Length > (CurrentQuestionIndex + 1));
        }

        public bool CheckAnswer(bool UserAnswer)
        {
            return (GetCurrentQuestion().Answer == UserAnswer);
        }
    }
}
