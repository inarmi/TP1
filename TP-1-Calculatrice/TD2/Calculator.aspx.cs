using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TD2
{
    public partial class Calculator : System.Web.UI.Page
    {
        public static string A="";
        public static string B = "";
        public static string O;
        public static float[] Archif=new float[10];
        public static int i = 0;
        public static float resu;
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public bool Operator()
        //{
        //    foreach (char x in TextBox1.Text)
        //    {
        //        if (x == '+' || x == '-' || x == '*' || x == '/')
        //            return true;
        //    }
        //    return false;
        //}

        public void ClickButton(string S)
        {
            A += S;
            TextBox1.Text += S;
            //Label1.Text = A;
            //if (Operator())
            //    B += S;
            //else
            //    A += S;
            //TextBox1.Text += S;
        }

        public float ButtonOperation(string S)
        {
                Archif[i] = float.Parse(A);
                if (i == 0)
                    resu = Archif[i];
                else
                    switch (O)
                    {
                        case "+": resu += Archif[i]; break;
                        case "-": resu -= Archif[i]; break;
                        case "*": resu *= Archif[i]; break;
                        case "/": resu /= Archif[i]; break;
                    }
                
                TextBox1.Text += S;
                Label1.Text = resu.ToString();
                A = "";
                O = S;
                i++;
                return resu;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            ClickButton(Button10.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            A = "";
            O = "x";
            Label1.Text = "";
            i = 0;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            ButtonOperation(Button5.Text);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            ClickButton(Button11.Text);
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Label1.Text = ButtonOperation(Button16.Text).ToString();
            //switch (O)
            //{
            //    case "+":int i = int.Parse(A);
            //        int j=int.Parse(B);
            //        int sum = i + j;
            //        TextBox1.Text = sum.ToString(); break;
            //    case "-":
            //         i = int.Parse(A);
            //         j = int.Parse(B);
            //         sum = i - j;
            //        TextBox1.Text = sum.ToString(); break;
            //    case "*":
            //        i = int.Parse(A);
            //        j = int.Parse(B);
            //        sum = i * j;
            //        TextBox1.Text = sum.ToString(); break;
            //    case "/":
            //        i = int.Parse(A);
            //        j = int.Parse(B);
            //        sum = i / j;
            //        TextBox1.Text = sum.ToString(); break;
            //}
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            ClickButton(Button12.Text);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            ClickButton(Button6.Text);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            ClickButton(Button7.Text);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            ClickButton(Button8.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClickButton(Button2.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ClickButton(Button3.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ClickButton(Button4.Text);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            ButtonOperation(Button9.Text);
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            ButtonOperation(Button13.Text);
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            ButtonOperation(Button17.Text);
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            ClickButton(Button14.Text);
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            ClickButton(Button15.Text);
        }
    }
}