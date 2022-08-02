namespace Notepad
{
    partial class AboutCurrentTab
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
            this._amountGroupBox = new System.Windows.Forms.GroupBox();
            this._wordsAmountLabel2 = new System.Windows.Forms.Label();
            this._charactersAmountLabel2 = new System.Windows.Forms.Label();
            this._wordsAmountLabel1 = new System.Windows.Forms.Label();
            this._charactersAmountLabel1 = new System.Windows.Forms.Label();
            this._wordRepeatmentStatisticsGroupBox = new System.Windows.Forms.GroupBox();
            this._wordRepeatmentStatisticsListBox = new System.Windows.Forms.ListBox();
            this._amountGroupBox.SuspendLayout();
            this._wordRepeatmentStatisticsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _amountGroupBox
            // 
            this._amountGroupBox.Controls.Add(this._wordsAmountLabel2);
            this._amountGroupBox.Controls.Add(this._charactersAmountLabel2);
            this._amountGroupBox.Controls.Add(this._wordsAmountLabel1);
            this._amountGroupBox.Controls.Add(this._charactersAmountLabel1);
            this._amountGroupBox.Location = new System.Drawing.Point(43, 47);
            this._amountGroupBox.Name = "_amountGroupBox";
            this._amountGroupBox.Size = new System.Drawing.Size(352, 122);
            this._amountGroupBox.TabIndex = 0;
            this._amountGroupBox.TabStop = false;
            this._amountGroupBox.Text = "Amount";
            // 
            // _wordsAmountLabel2
            // 
            this._wordsAmountLabel2.AutoSize = true;
            this._wordsAmountLabel2.Location = new System.Drawing.Point(278, 82);
            this._wordsAmountLabel2.Name = "_wordsAmountLabel2";
            this._wordsAmountLabel2.Size = new System.Drawing.Size(50, 20);
            this._wordsAmountLabel2.TabIndex = 3;
            this._wordsAmountLabel2.Text = "label4";
            // 
            // _charactersAmountLabel2
            // 
            this._charactersAmountLabel2.AutoSize = true;
            this._charactersAmountLabel2.Location = new System.Drawing.Point(278, 42);
            this._charactersAmountLabel2.Name = "_charactersAmountLabel2";
            this._charactersAmountLabel2.Size = new System.Drawing.Size(50, 20);
            this._charactersAmountLabel2.TabIndex = 2;
            this._charactersAmountLabel2.Text = "label3";
            // 
            // _wordsAmountLabel1
            // 
            this._wordsAmountLabel1.AutoSize = true;
            this._wordsAmountLabel1.Location = new System.Drawing.Point(22, 82);
            this._wordsAmountLabel1.Name = "_wordsAmountLabel1";
            this._wordsAmountLabel1.Size = new System.Drawing.Size(54, 20);
            this._wordsAmountLabel1.TabIndex = 1;
            this._wordsAmountLabel1.Text = "Words:";
            // 
            // _charactersAmountLabel1
            // 
            this._charactersAmountLabel1.AutoSize = true;
            this._charactersAmountLabel1.Location = new System.Drawing.Point(22, 42);
            this._charactersAmountLabel1.Name = "_charactersAmountLabel1";
            this._charactersAmountLabel1.Size = new System.Drawing.Size(81, 20);
            this._charactersAmountLabel1.TabIndex = 0;
            this._charactersAmountLabel1.Text = "Characters:";
            // 
            // _wordRepeatmentStatisticsGroupBox
            // 
            this._wordRepeatmentStatisticsGroupBox.Controls.Add(this._wordRepeatmentStatisticsListBox);
            this._wordRepeatmentStatisticsGroupBox.Location = new System.Drawing.Point(43, 193);
            this._wordRepeatmentStatisticsGroupBox.Name = "_wordRepeatmentStatisticsGroupBox";
            this._wordRepeatmentStatisticsGroupBox.Size = new System.Drawing.Size(352, 271);
            this._wordRepeatmentStatisticsGroupBox.TabIndex = 1;
            this._wordRepeatmentStatisticsGroupBox.TabStop = false;
            this._wordRepeatmentStatisticsGroupBox.Text = "Words repeatment statistics";
            // 
            // _wordRepeatmentStatisticsListBox
            // 
            this._wordRepeatmentStatisticsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._wordRepeatmentStatisticsListBox.FormattingEnabled = true;
            this._wordRepeatmentStatisticsListBox.ItemHeight = 20;
            this._wordRepeatmentStatisticsListBox.Location = new System.Drawing.Point(22, 41);
            this._wordRepeatmentStatisticsListBox.Name = "_wordRepeatmentStatisticsListBox";
            this._wordRepeatmentStatisticsListBox.Size = new System.Drawing.Size(306, 224);
            this._wordRepeatmentStatisticsListBox.TabIndex = 0;
            // 
            // AboutCurrentTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 476);
            this.Controls.Add(this._wordRepeatmentStatisticsGroupBox);
            this.Controls.Add(this._amountGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AboutCurrentTab";
            this.Text = "About Current Tab";
            this._amountGroupBox.ResumeLayout(false);
            this._amountGroupBox.PerformLayout();
            this._wordRepeatmentStatisticsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox _amountGroupBox;
        private Label _wordsAmountLabel2;
        private Label _charactersAmountLabel2;
        private Label _wordsAmountLabel1;
        private Label _charactersAmountLabel1;
        private GroupBox _wordRepeatmentStatisticsGroupBox;
        private ListBox _wordRepeatmentStatisticsListBox;
    }
}