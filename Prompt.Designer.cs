namespace Notepad
{
    partial class Prompt
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
            this._createButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._browsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._filePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _createButton
            // 
            this._createButton.Location = new System.Drawing.Point(112, 177);
            this._createButton.Name = "_createButton";
            this._createButton.Size = new System.Drawing.Size(94, 29);
            this._createButton.TabIndex = 0;
            this._createButton.Text = "Create";
            this._createButton.UseVisualStyleBackColor = true;
            this._createButton.Click += new System.EventHandler(this.CreateTabClick);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(278, 177);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(94, 29);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.CloseClick);
            // 
            // _fileName
            // 
            this._fileName.Location = new System.Drawing.Point(182, 50);
            this._fileName.Name = "_fileName";
            this._fileName.Size = new System.Drawing.Size(190, 27);
            this._fileName.TabIndex = 2;
            this._fileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name";
            // 
            // _browsButton
            // 
            this._browsButton.Location = new System.Drawing.Point(392, 90);
            this._browsButton.Name = "_browsButton";
            this._browsButton.Size = new System.Drawing.Size(77, 29);
            this._browsButton.TabIndex = 4;
            this._browsButton.Text = "Brows";
            this._browsButton.UseVisualStyleBackColor = true;
            this._browsButton.Click += new System.EventHandler(this.BrowsClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Path";
            // 
            // _filePath
            // 
            this._filePath.Location = new System.Drawing.Point(182, 90);
            this._filePath.Name = "_filePath";
            this._filePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._filePath.Size = new System.Drawing.Size(190, 27);
            this._filePath.TabIndex = 5;
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._filePath);
            this.Controls.Add(this._browsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._fileName);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._createButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Prompt";
            this.Text = "Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _createButton;
        private Button _cancelButton;
        private TextBox _fileName;
        private Label label1;
        private Button _browsButton;
        private Label label2;
        private TextBox _filePath;
    }
}