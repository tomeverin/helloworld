using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
            ButtonStartQuiz.Clicked += ButtonStartQuiz_Clicked;
		}

        private void ButtonStartQuiz_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuizPage());
        }
    }
}
