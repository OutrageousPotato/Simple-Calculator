using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simple_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonPlus_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textboxFirstValue.Text);
            double secondValue = double.Parse(textboxSecondValue.Text);

            double answer = firstValue + secondValue;

            answerLabel.Text = answer.ToString();
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textboxFirstValue.Text);
            double secondValue = double.Parse(textboxSecondValue.Text);

            double answer = firstValue - secondValue;

            answerLabel.Text = answer.ToString();
        }

        protected void buttonMultiply_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textboxFirstValue.Text);
            double secondValue = double.Parse(textboxSecondValue.Text);

            double answer = firstValue * secondValue;

            answerLabel.Text = answer.ToString();
        }

        protected void buttonDivide_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textboxFirstValue.Text);
            double secondValue = double.Parse(textboxSecondValue.Text);

            double answer = firstValue / secondValue;

            answerLabel.Text = answer.ToString();
        }
    }
}