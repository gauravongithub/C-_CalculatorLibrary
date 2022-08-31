namespace CalculatorUserInterface
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.standardCalculator = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.memoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calculatorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.operationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.standardCalculator.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // standardCalculator
            // 
            this.standardCalculator.ColumnCount = 2;
            this.standardCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.80808F));
            this.standardCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.19192F));
            this.standardCalculator.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.standardCalculator.Location = new System.Drawing.Point(4, 4);
            this.standardCalculator.Name = "standardCalculator";
            this.standardCalculator.RowCount = 2;
            this.standardCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064516F));
            this.standardCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.93549F));
            this.standardCalculator.Size = new System.Drawing.Size(792, 434);
            this.standardCalculator.TabIndex = 0;
            
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.memoryPanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.calculatorPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.operationPanel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.59287F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.9771F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.68448F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 394);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // memoryPanel
            // 
            this.memoryPanel.ColumnCount = 5;
            this.memoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryPanel.Location = new System.Drawing.Point(3, 79);
            this.memoryPanel.Name = "memoryPanel";
            this.memoryPanel.RowCount = 1;
            this.memoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.memoryPanel.Size = new System.Drawing.Size(628, 45);
            this.memoryPanel.TabIndex = 0;
            // 
            // calculatorPanel
            // 
            this.calculatorPanel.ColumnCount = 1;
            this.calculatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.calculatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.calculatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatorPanel.Location = new System.Drawing.Point(3, 3);
            this.calculatorPanel.Name = "calculatorPanel";
            this.calculatorPanel.RowCount = 2;
            this.calculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calculatorPanel.Size = new System.Drawing.Size(628, 70);
            this.calculatorPanel.TabIndex = 1;
            // 
            // operationPanel
            // 
            this.operationPanel.ColumnCount = 4;
            this.operationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationPanel.Location = new System.Drawing.Point(3, 130);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.RowCount = 6;
            this.operationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.operationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.operationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.operationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.operationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.operationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.operationPanel.Size = new System.Drawing.Size(628, 261);
            this.operationPanel.TabIndex = 2;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.standardCalculator);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
           
            this.standardCalculator.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel standardCalculator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel memoryPanel;
        private System.Windows.Forms.TableLayoutPanel calculatorPanel;
        private System.Windows.Forms.TableLayoutPanel operationPanel;
    }
}

