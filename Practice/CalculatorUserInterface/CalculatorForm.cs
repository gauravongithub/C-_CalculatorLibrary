using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalculatorLibrary;
using System.IO;
using System.Text.Json;


namespace CalculatorUserInterface
{

    public partial class CalculatorForm : Form
    {
        private List<Button> buttons = new List<Button>();
        private readonly TextBox resultArea, inputArea;

        public CalculatorForm()
        {

            resultArea = new TextBox();
            inputArea = new TextBox();
            InitializeComponent();
            InitializeButtons();
            InitializeDisplay();

        }
        
        private void InitializeDisplay()
        {
           
            calculatorPanel.Controls.Add(inputDisplayPad,0,0);
            inputDisplayPad.Dock = DockStyle.Fill;
            inputDisplayPad.Name = "inputPad";

            calculatorPanel.Controls.Add(resultDisplayPad,0,1);
            resultDisplayPad.Dock = DockStyle.Fill;
            resultDisplayPad.Name = "resultPad";
            resultDisplayPad.Text = "";
        }


        private void InitializeButtons()
        {
            List<Buttons> buttonDetails = new List<Buttons>();
             using (StreamReader s = new StreamReader("ButtonDetails.json"))
            {
                buttonDetails = JsonSerializer.Deserialize<List<Buttons>>(s.ReadToEnd());
            }

            for (int j= 0; j < buttonDetails.Count; j++)
            {
                buttons.Add(new Button());
            }

            int i=0;
            foreach(Buttons button in buttons)
            {
                button.Dock = DockStyle.Fill;
                button.Name = buttonDetails[i].buttonName;
                button.Text = buttonDetails[i].buttonName;
                button.Tag = buttonDetails[i].expText;
                if (buttonDetails[i].panelName == "memoryPanel")
                {
                    memoryPanel.Controls.Add(button, buttonDetails[i].indexCol, buttonDetails[i].indexRow);
                }
                if (buttonDetails[i].panelName == "operationPanel")
                {
                    operationPanel.Controls.Add(button, buttonDetails[i].indexCol, buttonDetails[i].indexRow);
                }
                button.Click += new EventHandler(buttonPress);
                i++;

            }
        }



        private void buttonPress(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Tag != null)
            {
                inputDisplayPad.Text += button.Tag;
            }
            else if(button.Tag == null)
            {
                if (button.Name == "MC")
                {
                    
                }
                else if (button.Name == "MR")
                {

                }
                else if (button.Name == "M+")
                {

                }
                else if (button.Name == "M-")
                {

                }
                else if (button.Name == "MS")
                {

                }
                else if (button.Name == "=")
                {
                    double result = 0;
                    Evaluator ev= new Evaluator();
                    result =  ev.Evaluate(inputDisplayPad.Text);
                    resultDisplayPad.Text= result.ToString();
                }
                else if (button.Name == "<-")
                {
                    string s = "";
                    for (int i = 0; i < inputDisplayPad.TextLength-1; i++)
                        s += inputDisplayPad.Text[i].ToString();
                    inputDisplayPad.Text = s;
                }
                else if (button.Name == "C")
                {

                    inputDisplayPad.Text = "";
                    resultDisplayPad.Text = "";
                }
                else if (button.Name == "CE")
                {
                    int i;
                    for(i=inputDisplayPad.TextLength-1; i>=0;i--)
                    {
                        if (inputDisplayPad.Text[i] == '.' || char.IsDigit(inputDisplayPad.Text[i]))
                         {

                        } else
                            break;
                    }
                    string s="";
                    for (int j = 0; j <= i; j++)
                        s += inputDisplayPad.Text[j];
                    inputDisplayPad.Text = s;
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

    public class Buttons
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string panelName { get; set; }
        public string buttonName { get; set; }
        public string value { get; set; }
    }
}
