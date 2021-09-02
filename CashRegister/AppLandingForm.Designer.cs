
namespace CashRegister
{
    partial class AppLandingForm
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
            System.Windows.Forms.Label InputLbl;
            System.Windows.Forms.Label OutputLbl;
            System.Windows.Forms.Label HowToUseLbl;
            System.Windows.Forms.TextBox textBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLandingForm));
            System.Windows.Forms.Label label4;
            this.PreferredCurrencyLbl = new System.Windows.Forms.Label();
            this.PreferredCurrencyNoteLbl = new System.Windows.Forms.TextBox();
            this.TransactionInputTxt = new System.Windows.Forms.TextBox();
            this.TransactionOutputTxt = new System.Windows.Forms.TextBox();
            this.UploadFileBtn = new System.Windows.Forms.Button();
            this.ProcessInputsBtn = new System.Windows.Forms.Button();
            this.CountrySelectorCB = new System.Windows.Forms.ComboBox();
            this.PreferredCurrencyCB = new System.Windows.Forms.ComboBox();
            this.OpenFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.OutputFileLocationTxt = new System.Windows.Forms.TextBox();
            InputLbl = new System.Windows.Forms.Label();
            OutputLbl = new System.Windows.Forms.Label();
            HowToUseLbl = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputLbl
            // 
            InputLbl.AutoSize = true;
            InputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            InputLbl.Location = new System.Drawing.Point(12, 194);
            InputLbl.Name = "InputLbl";
            InputLbl.Size = new System.Drawing.Size(39, 16);
            InputLbl.TabIndex = 3;
            InputLbl.Text = "Input:";
            // 
            // OutputLbl
            // 
            OutputLbl.AutoSize = true;
            OutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            OutputLbl.Location = new System.Drawing.Point(347, 194);
            OutputLbl.Name = "OutputLbl";
            OutputLbl.Size = new System.Drawing.Size(49, 16);
            OutputLbl.TabIndex = 4;
            OutputLbl.Text = "Output:";
            // 
            // HowToUseLbl
            // 
            HowToUseLbl.AutoSize = true;
            HowToUseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            HowToUseLbl.Location = new System.Drawing.Point(347, 15);
            HowToUseLbl.Name = "HowToUseLbl";
            HowToUseLbl.Size = new System.Drawing.Size(86, 16);
            HowToUseLbl.TabIndex = 7;
            HowToUseLbl.Text = "How To Use:";
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.SystemColors.Control;
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox3.Location = new System.Drawing.Point(350, 45);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(496, 128);
            textBox3.TabIndex = 9;
            textBox3.TabStop = false;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            label4.Location = new System.Drawing.Point(12, 82);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 16);
            label4.TabIndex = 11;
            label4.Text = "Select Country";
            // 
            // PreferredCurrencyLbl
            // 
            this.PreferredCurrencyLbl.AutoSize = true;
            this.PreferredCurrencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PreferredCurrencyLbl.Location = new System.Drawing.Point(149, 82);
            this.PreferredCurrencyLbl.Name = "PreferredCurrencyLbl";
            this.PreferredCurrencyLbl.Size = new System.Drawing.Size(120, 16);
            this.PreferredCurrencyLbl.TabIndex = 12;
            this.PreferredCurrencyLbl.Text = "Preferred Currency";
            // 
            // PreferredCurrencyNoteLbl
            // 
            this.PreferredCurrencyNoteLbl.BackColor = System.Drawing.SystemColors.Control;
            this.PreferredCurrencyNoteLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreferredCurrencyNoteLbl.Location = new System.Drawing.Point(12, 129);
            this.PreferredCurrencyNoteLbl.Multiline = true;
            this.PreferredCurrencyNoteLbl.Name = "PreferredCurrencyNoteLbl";
            this.PreferredCurrencyNoteLbl.ReadOnly = true;
            this.PreferredCurrencyNoteLbl.Size = new System.Drawing.Size(312, 44);
            this.PreferredCurrencyNoteLbl.TabIndex = 14;
            this.PreferredCurrencyNoteLbl.TabStop = false;
            this.PreferredCurrencyNoteLbl.Text = "Some countries have multiple currencies. Select the desired currency to process t" +
    "ransactions with.";
            // 
            // TransactionInputTxt
            // 
            this.TransactionInputTxt.AcceptsReturn = true;
            this.TransactionInputTxt.AllowDrop = true;
            this.TransactionInputTxt.Location = new System.Drawing.Point(12, 213);
            this.TransactionInputTxt.Multiline = true;
            this.TransactionInputTxt.Name = "TransactionInputTxt";
            this.TransactionInputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransactionInputTxt.Size = new System.Drawing.Size(312, 355);
            this.TransactionInputTxt.TabIndex = 9;
            // 
            // TransactionOutputTxt
            // 
            this.TransactionOutputTxt.Location = new System.Drawing.Point(350, 213);
            this.TransactionOutputTxt.Multiline = true;
            this.TransactionOutputTxt.Name = "TransactionOutputTxt";
            this.TransactionOutputTxt.ReadOnly = true;
            this.TransactionOutputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TransactionOutputTxt.Size = new System.Drawing.Size(496, 355);
            this.TransactionOutputTxt.TabIndex = 1;
            this.TransactionOutputTxt.TabStop = false;
            this.TransactionOutputTxt.WordWrap = false;
            // 
            // UploadFileBtn
            // 
            this.UploadFileBtn.Location = new System.Drawing.Point(12, 15);
            this.UploadFileBtn.Name = "UploadFileBtn";
            this.UploadFileBtn.Size = new System.Drawing.Size(312, 23);
            this.UploadFileBtn.TabIndex = 5;
            this.UploadFileBtn.Text = "Upload File";
            this.UploadFileBtn.UseVisualStyleBackColor = true;
            this.UploadFileBtn.Click += new System.EventHandler(this.UploadFileBtn_Click);
            // 
            // ProcessInputsBtn
            // 
            this.ProcessInputsBtn.Location = new System.Drawing.Point(12, 44);
            this.ProcessInputsBtn.Name = "ProcessInputsBtn";
            this.ProcessInputsBtn.Size = new System.Drawing.Size(312, 23);
            this.ProcessInputsBtn.TabIndex = 6;
            this.ProcessInputsBtn.Text = "Process Inputs";
            this.ProcessInputsBtn.UseVisualStyleBackColor = true;
            this.ProcessInputsBtn.Click += new System.EventHandler(this.ProcessInputsBtn_Click);
            // 
            // CountrySelectorCB
            // 
            this.CountrySelectorCB.FormattingEnabled = true;
            this.CountrySelectorCB.Location = new System.Drawing.Point(15, 102);
            this.CountrySelectorCB.Name = "CountrySelectorCB";
            this.CountrySelectorCB.Size = new System.Drawing.Size(121, 21);
            this.CountrySelectorCB.TabIndex = 7;
            this.CountrySelectorCB.SelectedIndexChanged += new System.EventHandler(this.CountrySelectorCB_SelectedIndexChanged);
            // 
            // PreferredCurrencyCB
            // 
            this.PreferredCurrencyCB.FormattingEnabled = true;
            this.PreferredCurrencyCB.Items.AddRange(new object[] {
            "Bills",
            "Coins"});
            this.PreferredCurrencyCB.Location = new System.Drawing.Point(152, 102);
            this.PreferredCurrencyCB.Name = "PreferredCurrencyCB";
            this.PreferredCurrencyCB.Size = new System.Drawing.Size(121, 21);
            this.PreferredCurrencyCB.TabIndex = 13;
            // 
            // OpenFileBrowser
            // 
            this.OpenFileBrowser.FileName = "OpenFileBrowser";
            // 
            // OutputFileLocationTxt
            // 
            this.OutputFileLocationTxt.BackColor = System.Drawing.SystemColors.Control;
            this.OutputFileLocationTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputFileLocationTxt.Location = new System.Drawing.Point(12, 574);
            this.OutputFileLocationTxt.Name = "OutputFileLocationTxt";
            this.OutputFileLocationTxt.ReadOnly = true;
            this.OutputFileLocationTxt.Size = new System.Drawing.Size(834, 13);
            this.OutputFileLocationTxt.TabIndex = 15;
            this.OutputFileLocationTxt.TabStop = false;
            this.OutputFileLocationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AppLandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 613);
            this.Controls.Add(this.OutputFileLocationTxt);
            this.Controls.Add(this.PreferredCurrencyNoteLbl);
            this.Controls.Add(this.PreferredCurrencyCB);
            this.Controls.Add(this.PreferredCurrencyLbl);
            this.Controls.Add(label4);
            this.Controls.Add(this.CountrySelectorCB);
            this.Controls.Add(textBox3);
            this.Controls.Add(HowToUseLbl);
            this.Controls.Add(this.ProcessInputsBtn);
            this.Controls.Add(this.UploadFileBtn);
            this.Controls.Add(OutputLbl);
            this.Controls.Add(InputLbl);
            this.Controls.Add(this.TransactionOutputTxt);
            this.Controls.Add(this.TransactionInputTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AppLandingForm";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.AppLandingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TransactionInputTxt;
        private System.Windows.Forms.TextBox TransactionOutputTxt;
        private System.Windows.Forms.Button UploadFileBtn;
        private System.Windows.Forms.Button ProcessInputsBtn;
        private System.Windows.Forms.ComboBox CountrySelectorCB;
        private System.Windows.Forms.ComboBox PreferredCurrencyCB;
        private System.Windows.Forms.Label PreferredCurrencyLbl;
        private System.Windows.Forms.TextBox PreferredCurrencyNoteLbl;
        private System.Windows.Forms.OpenFileDialog OpenFileBrowser;
        private System.Windows.Forms.TextBox OutputFileLocationTxt;
    }
}

