﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
	public partial class QuizPage : ContentPage
	{
        Quiz MyQuiz = new Quiz();
        bool UserResponse = false;
        int CounterCorrectAnswers = 0;

		public QuizPage ()
		{
			InitializeComponent ();

            btnTrue.Clicked += BtnTrue_Clicked;
            btnFalse.Clicked += BtnFalse_Clicked;
            btnNext.Clicked += BtnNext_Clicked;

            SetupQuestion(MyQuiz.GetCurrentQuestion());

		}

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            if (MyQuiz.HasMoreQuestions()) { 
                MyQuiz.SelectNextQuestion();
                SetupQuestion(MyQuiz.GetCurrentQuestion());
            }
            else
            {
                Navigation.PushAsync(new SummaryPage(CounterCorrectAnswers));
            }
        }

        private void BtnFalse_Clicked(object sender, EventArgs e)
        {
            UserResponse = false;
            CheckAnswer();
        }

        private void BtnTrue_Clicked(object sender, EventArgs e)
        {
            UserResponse = true;
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            if (MyQuiz.CheckAnswer(UserResponse))
            {
                lblFeedback.Text = "Correct";
                CounterCorrectAnswers++;            
            } else
            {
                lblFeedback.Text = "Incorrect";
            }

            btnFalse.IsEnabled = false;
            btnTrue.IsEnabled = false;
            btnNext.IsEnabled = true;
        } 

        private void SetupQuestion(Question question)
        {
            lblQuestion.Text = question.QuestionText;
            lblFeedback.Text = "";
            btnFalse.IsEnabled = true;
            btnTrue.IsEnabled = true;
            btnNext.IsEnabled = false;
        }
	}
}
