using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class flightCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (val())
            {
                double initHeight = Convert.ToDouble(height.Text);
                double initSpeed = Convert.ToDouble(speed.Text);
                double deg = Convert.ToDouble(degree.Text);

                flightService.WebService1 ws = new flightService.WebService1();
                double[] arr = ws.TimeCalc(initHeight, initSpeed, deg);

                for (int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            distAns.Text = "The distance is: " + arr[0];
                            break;
                        case 1:
                            sAns.Text = "The impact speed is: " + arr[1];
                            break;
                        case 2:
                            degAns.Text = "The degree of the projectile is: " + arr[2];
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Label4.Text = "Please enter valid numbers and try again.";
            }
        }

        protected bool val()
        {
            bool ok = true;
            if (Double.IsNaN(Convert.ToDouble(height.Text)))
            {
                ok = false;
            }
            if (Double.IsNaN(Convert.ToDouble(speed.Text)))
            {
                ok = false;
            }
            else
            {
                if(Convert.ToDouble(speed.Text) <= 0)
                {
                    ok = false;
                }
            }
            if (Double.IsNaN(Convert.ToDouble(degree.Text)))
            {
                ok = false;
            }
            else
            {
                if(!(Convert.ToDouble(degree.Text) < 90 && Convert.ToDouble(degree.Text) > 0))
                {
                    ok = false;
                }
            }
            return ok;
        }
    }
}