namespace _3.Antivirus_search
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
            this.label1 = new System.Windows.Forms.Label();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.targetFileTextBox = new System.Windows.Forms.TextBox();
            this.limitLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedFolderTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Смещение";
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Enabled = false;
            this.offsetTextBox.Location = new System.Drawing.Point(122, 33);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(244, 20);
            this.offsetTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина (байт)";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Enabled = false;
            this.lengthTextBox.Location = new System.Drawing.Point(122, 67);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(245, 20);
            this.lengthTextBox.TabIndex = 3;
            // 
            // targetFileTextBox
            // 
            this.targetFileTextBox.Enabled = false;
            this.targetFileTextBox.Location = new System.Drawing.Point(522, 32);
            this.targetFileTextBox.Name = "targetFileTextBox";
            this.targetFileTextBox.Size = new System.Drawing.Size(182, 20);
            this.targetFileTextBox.TabIndex = 4;
            // 
            // limitLabel
            // 
            this.limitLabel.AutoSize = true;
            this.limitLabel.Location = new System.Drawing.Point(381, 37);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(24, 13);
            this.limitLabel.TabIndex = 5;
            this.limitLabel.Text = "limit";
            this.limitLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выберите файл в качестве маски";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(47, 107);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(126, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Начать поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(47, 227);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(728, 199);
            this.resultsListBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результаты поиска";
            // 
            // selectedFolderTextBox
            // 
            this.selectedFolderTextBox.Enabled = false;
            this.selectedFolderTextBox.Location = new System.Drawing.Point(522, 70);
            this.selectedFolderTextBox.Name = "selectedFolderTextBox";
            this.selectedFolderTextBox.Size = new System.Drawing.Size(182, 20);
            this.selectedFolderTextBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(726, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Выберите папку для поиска";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.selectedFolderTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.limitLabel);
            this.Controls.Add(this.targetFileTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.offsetTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "4. Поиск по сигнатуре";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox offsetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox targetFileTextBox;
        private System.Windows.Forms.Label limitLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox selectedFolderTextBox;
        private System.Windows.Forms.Button button2;
    }
}

