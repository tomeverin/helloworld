using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
	public partial class SummaryPage : ContentPage
	{
		public SummaryPage (int number)
		{
			InitializeComponent ();
            LabelSummary.Text = "You scored " + number + " out of 3 questions correctly.";
		}
	}
}
