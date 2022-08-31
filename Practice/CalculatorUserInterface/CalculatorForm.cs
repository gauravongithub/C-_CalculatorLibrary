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
           
            calculatorPanel.Controls.Add(inputArea,0,0);
            inputArea.Dock = DockStyle.Fill;
            inputArea.Name = "inputPad";

            calculatorPanel.Controls.Add(resultArea,0,1);
            resultArea.Dock = DockStyle.Fill;
            resultArea.Name = "resultPad";
            resultArea.Text = "";
        }


        private void InitializeButtons()
        {
            List<Buttons> buttonDetails = new List<Buttons>();
             using (StreamReader s = new StreamReader("../../ButtonDetails.json"))
            {
                buttonDetails = JsonSerializer.Deserialize<List<Buttons>>(s.ReadToEnd());
            }

            for (int j= 0; j < buttonDetails.Count; j++)
            {
                buttons.Add(new Button());
            }

            int i=0;
            foreach(Button button in buttons)
            {
                button.Dock = DockStyle.Fill;
                button.Name = buttonDetails[i].buttonName;
                button.Text = buttonDetails[i].buttonName;
                button.Tag = buttonDetails[i].value;
                if (buttonDetails[i].panelName == "memoryPanel")
                {
                    memoryPanel.Controls.Add(button, buttonDetails[i].Col, buttonDetails[i].Row);
                }
                if (buttonDetails[i].panelName == "operationPanel")
                {
                    operationPanel.Controls.Add(button, buttonDetails[i].Col, buttonDetails[i].Row);
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
                inputArea.Text += button.Tag;
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
                    EvaluatorClass ev= new EvaluatorClass();
                    result =  ev.Evaluate(inputArea.Text);
                    resultArea.Text= result.ToString();
                }
                else if (button.Name == "<-")
                {
                    string s = "";
                    for (int i = 0; i < inputArea.TextLength-1; i++)
                        s += inputArea.Text[i].ToString();
                    inputArea.Text = s;
                }
                else if (button.Name == "C")
                {

                    inputArea.Text = "";
                    resultArea.Text = "";
                }
                else if (button.Name == "CE")
                {
                    int i;
                    for(i=inputArea.TextLength-1; i>=0;i--)
                    {
                        if (inputArea.Text[i] == '.' || char.IsDigit(inputArea.Text[i]))
                         {

                        } else
                            break;
                    }
                    string s="";
                    for (int j = 0; j <= i; j++)
                        s += inputArea.Text[j];
                    inputArea.Text = s;
                }
            }
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
