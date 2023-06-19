using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToBinaryConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            List<int> decimalValues = new List<int>(); //creates list

            if (lblBox1.Text == "Text") //if lblBox1 says "Text" execute
            {
                txtBox2.Text = ""; //clear txtBox2
                string textToConvert = txtBox1.Text; //textToConvert variable equals the text in txtBox1
                foreach (char character in textToConvert) //for each character in textToConvert execute
                {
                    int charValues = (int)character; //character is converted to its deciaml value
                    decimalValues.Add(charValues); //decimal value is add to list
                    txtBox2.Text += charValues.ToString() + Environment.NewLine; //decimal value is added to txtBox2 along with new line
                    string[] txtArray = txtBox2.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries); //array "txtarray" is created which equals the text in txtBox2 split by each new line
                    txtBox2.Text = ""; //txtBox2 is cleared
                    
                }
                foreach (int line in decimalValues) //for each integar in list execute
                {
                    int value = Convert.ToInt32(line); //integar value "value" is created and is equal to the number on each line of list "decimalValues"
                    string binary = Convert.ToString(value, 2); //string value "binary" is created and is equal to the "value" variable converted to binary 
                    txtBox2.Text += binary + " "; //txtBox2 shows binary plus a space behing it
                }
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (lblBox1.Text == "Text") //if lblBox1 says "Text" execute
            {
                lblBox1.Text = "Binary"; //lblBox1 changes to say "Binary"
                lblBox2.Text = "Text";//lblBox2 changes to say "Text"
                string textInBox1 = txtBox1.Text; //string varible "textInBox1" is equal to the text in txtBox1
                string textInBox2 = txtBox2.Text; //string varible "textInBox2" is equal to the text in txtBox2
                txtBox1.Text = textInBox2; //text in txtBox1 is changed to equal textInBox2
                txtBox2.Text = textInBox1;//text in txtBox2 is changed to equal textInBox1
            }
            else //if lblBox1 doesn't say "Text" execute
            {
                lblBox1.Text = "Text"; //lblBox1 changes to say "Text"
                lblBox2.Text = "Binary"; //lblBox2 changes to say "Binary"
                string textInBox1 = txtBox1.Text; //string varible "textInBox1" is equal to the text in txtBox1
                string textInBox2 = txtBox2.Text; //string varible "textInBox2" is equal to the text in txtBox2
                txtBox1.Text = textInBox2;//text in txtBox1 is changed to equal textInBox2
                txtBox2.Text = textInBox1;//text in txtBox2 is changed to equal textInBox1
            }
        }

    }
}
