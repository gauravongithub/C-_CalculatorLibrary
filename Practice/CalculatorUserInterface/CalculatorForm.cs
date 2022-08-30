using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;


namespace CalculatorUserInterface
{

    public partial class CalculatorForm : Form
    {
        public List<Buttons> buttons = new List<Buttons>();
        public CalculatorForm()
        {
            InitializeComponent();

            using (StreamReader s = new StreamReader("ButtonDetails.json"))
            {
                buttons = JsonSerializer.Deserialize<List<Buttons>>(s.ReadToEnd());
            }


            foreach (Buttons button in buttons)
            {
                buttons.Add(new Buttons());
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
        public int IndexX { get; set; }
        public int IndexY { get; set; }
        public string Panel { get; set; }
        public string Operator { get; set; }
    }
}
