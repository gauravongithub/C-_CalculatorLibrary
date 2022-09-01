using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalculatorLibrary;
using System.IO;
using System.Text.Json;
using System.Drawing;

namespace CalculatorUserInterface
{

    public partial class CalculatorForm : Form
    {
        private List<Button> buttons = new List<Button>();
        private ListView memoryList;
        private readonly TextBox resultArea, inputArea;
        private Label calculatorHeading, memoryHeading;

        public CalculatorForm()
        {
            calculatorHeading = new Label();
            memoryHeading = new Label();
            memoryList = new ListView();
            resultArea = new TextBox();
            inputArea = new TextBox();
            InitializeComponent();
            InitializeButtons();
            InitializeDisplay();
            InitializeMemoryList();

        }

        private void InitializeMemoryList()
        {
            //Calculator Heading design
            standardCalculator.Controls.Add(calculatorHeading, 0, 0);
            standardCalculator.Controls.Add(memoryHeading, 1,0);
            standardCalculator.Controls.Add(memoryList,1,1);
            calculatorHeading.Font = new Font("Serif", 15, FontStyle.Underline);
            calculatorHeading.BackColor = Color.Purple;
            calculatorHeading.ForeColor = Color.White;
            calculatorHeading.Text = "Calculator";
            calculatorHeading.TextAlign = ContentAlignment.MiddleRight;

            memoryHeading.Font = new Font("Serif", 15, FontStyle.Underline);
            memoryHeading.Text = "Memory Stack";
            memoryHeading.BackColor = Color.Purple;
            memoryHeading.ForeColor = Color.White;

            memoryList.Font = new Font("Serif", 15, FontStyle.Regular);
            memoryList.Dock = DockStyle.Fill;
            memoryList.Name = "MemoryList";
            memoryList.View = View.Details;
            memoryList.Columns.Add("Memory");
            memoryList.HeaderStyle = ColumnHeaderStyle.None;          
            List<Double> memoryListDetails = new List<Double>();
            memoryList.Items.Clear();
            foreach (double value in memoryListDetails)
            {
                memoryList.Items.Insert(0, value.ToString());
            }

        }
        
        private void InitializeDisplay()
        {
           
            calculatorPanel.Controls.Add(inputArea,0,0);
            inputArea.Dock = DockStyle.Fill;
            inputArea.Name = "inputPad";
            calculatorPanel.Controls.Add(resultArea,0,1);
            resultArea.Dock = DockStyle.Fill;
            resultArea.Name = "resultPad";
            resultArea.Text = String.Empty;
            resultArea.Font = new Font("Serif", 24,FontStyle.Bold);
            resultArea.BorderStyle = BorderStyle.Fixed3D;
            inputArea.Font = new Font("Serif", 15, FontStyle.Bold);
            inputArea.BorderStyle = BorderStyle.Fixed3D;
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
            foreach(Button button in buttons)
            {
                button.Dock = DockStyle.Fill;
                button.Name = buttonDetails[i].buttonName;
                button.Text = buttonDetails[i].buttonName;
                button.Tag = buttonDetails[i].value;
                button.Font = new Font("Serif", 15, FontStyle.Regular);
                if (buttonDetails[i].panelName == "memoryPanel")
                {
                    memoryPanel.Controls.Add(button, buttonDetails[i].Col, buttonDetails[i].Row);
                }
                if (buttonDetails[i].panelName == "operationPanel")
                {
                    operationPanel.Controls.Add(button, buttonDetails[i].Col, buttonDetails[i].Row);
                }
                button.Click +=  new EventHandler(buttonPress);
                i++;

            }
        }

        private void standardCalculator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void standardCalculator_Paint_1(object sender, PaintEventArgs e)
        {

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
                string memoryOperation = button.Name;
                switch (memoryOperation)
                {
                    case "MC":
                        MemoryOperations.MemoryClear();
                        break;

                    case "MR":
                       String temp = MemoryOperations.MemoryRecall().ToString();
                        inputArea.Text += temp;
                        break;
                    case "M+":
                        int answerLength = resultArea.Text.Length;
                        if(answerLength > 0 && !char.IsLetter(resultArea.Text[0]))
                        {
                            MemoryOperations.MemoryAdd(Double.Parse(resultArea.Text));
                        }
                        break;
                    case "M-":
                        int resultAreaLength = resultArea.Text.Length;
                        if (resultAreaLength > 0 && !char.IsLetter(resultArea.Text[0]))
                        {
                            MemoryOperations.MemorySubtract(Double.Parse(resultArea.Text));
                        }
                        break;
                    case "MS":
                        if(resultArea.Text == String.Empty)
                        {
                            resultArea.Text = inputArea.Text;
                        }
                        MemoryOperations.MemoryStore(Double.Parse(resultArea.Text));
                        break;
                    case "=":
                        try
                        {

                            double result = 0;
                            EvaluatorClass ev = new EvaluatorClass();
                            //SortedSet<String> typesOfOperators = new SortedSet<String>();
                            //TextBox tempInput = new TextBox();
                            //typesOfOperators.Add("+");
                            //typesOfOperators.Add("-");
                            //typesOfOperators.Add("*");
                            //typesOfOperators.Add("/");
                            //for(int inputAreaIndex = 0; inputAreaIndex <inputArea.Text.Length; inputAreaIndex++)
                            //{

                            //}
                            result = ev.Evaluate(inputArea.Text);
                            resultArea.Text = result.ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            resultArea.Text = "Cannot divide by zero";
                        }
                        catch(Exception ex)
                        {
                            resultArea.Text = "Invalid expression.";
                        }

                        break;
                    case "<-":
                        string s = String.Empty;
                        int i;
                        for ( i = 0; i < inputArea.TextLength - 1; i++)
                            s += inputArea.Text[i].ToString();
                        inputArea.Text = s;
                        break;
                    case "C":
                        inputArea.Text = String.Empty;
                        resultArea.Text = String.Empty;
                        break;
                    case "CE":
 
                        for (i = inputArea.TextLength - 1; i >= 0; i--)
                        {
                            if (inputArea.Text[i] == '.' || char.IsDigit(inputArea.Text[i]))
                            {

                            }
                            else
                                break;
                        }
                    
                        string sa = String.Empty;
                        for (int j = 0; j <= i; j++)
                            sa += inputArea.Text[j];
                        inputArea.Text = sa;
                        break;


                }
            }

            List<double> memoryView = MemoryOperations.viewMemory();
            memoryList.Items.Clear();
            if(memoryList!=null)
            {
                for (int i = memoryView.Count - 1; i >= 0; i--)
                {
                    memoryList.Items.Add(memoryView[i].ToString());
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
