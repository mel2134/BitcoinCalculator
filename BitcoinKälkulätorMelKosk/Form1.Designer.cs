namespace BitcoinKälkulätorMelKosk
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bitcoinAmountInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currencySelector = new System.Windows.Forms.ComboBox();
            this.tulemusLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bitcoinAmountInput
            // 
            this.bitcoinAmountInput.Location = new System.Drawing.Point(116, 63);
            this.bitcoinAmountInput.Name = "bitcoinAmountInput";
            this.bitcoinAmountInput.Size = new System.Drawing.Size(167, 20);
            this.bitcoinAmountInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mitu bitcoini konverteerida tahad?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vali valuuta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Konverteeri";
            // 
            // currencySelector
            // 
            this.currencySelector.FormattingEnabled = true;
            this.currencySelector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "EEK"});
            this.currencySelector.Location = new System.Drawing.Point(116, 127);
            this.currencySelector.Name = "currencySelector";
            this.currencySelector.Size = new System.Drawing.Size(167, 21);
            this.currencySelector.TabIndex = 5;
            this.currencySelector.Text = "Vali valuuta";
            // 
            // tulemusLabel
            // 
            this.tulemusLabel.AutoSize = true;
            this.tulemusLabel.Location = new System.Drawing.Point(12, 236);
            this.tulemusLabel.Name = "tulemusLabel";
            this.tulemusLabel.Size = new System.Drawing.Size(50, 13);
            this.tulemusLabel.TabIndex = 6;
            this.tulemusLabel.Text = "Tulemus:";
            this.tulemusLabel.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resultLabel.Location = new System.Drawing.Point(12, 255);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(350, 73);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "None";
            this.resultLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 397);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.tulemusLabel);
            this.Controls.Add(this.currencySelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bitcoinAmountInput);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bitcoinAmountInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox currencySelector;
        private System.Windows.Forms.Label tulemusLabel;
        private System.Windows.Forms.TextBox resultLabel;
    }
}

