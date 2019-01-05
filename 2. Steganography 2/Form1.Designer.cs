namespace Steganography2
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
            this.chooseFileForCypherButton = new System.Windows.Forms.Button();
            this.filepathForCypherTextBox = new System.Windows.Forms.TextBox();
            this.messageForCypherTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filepathForDecypherTextBox = new System.Windows.Forms.TextBox();
            this.fileForDecypherTextBox = new System.Windows.Forms.Button();
            this.decypheredMessageTextBox = new System.Windows.Forms.TextBox();
            this.decypherButton = new System.Windows.Forms.Button();
            this.cypherMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseFileForCypherButton
            // 
            this.chooseFileForCypherButton.Location = new System.Drawing.Point(353, 35);
            this.chooseFileForCypherButton.Name = "chooseFileForCypherButton";
            this.chooseFileForCypherButton.Size = new System.Drawing.Size(347, 23);
            this.chooseFileForCypherButton.TabIndex = 0;
            this.chooseFileForCypherButton.Text = "Выберите текст в котором будет содержаться шифровка";
            this.chooseFileForCypherButton.UseVisualStyleBackColor = true;
            this.chooseFileForCypherButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // filepathForCypherTextBox
            // 
            this.filepathForCypherTextBox.Enabled = false;
            this.filepathForCypherTextBox.Location = new System.Drawing.Point(33, 35);
            this.filepathForCypherTextBox.Name = "filepathForCypherTextBox";
            this.filepathForCypherTextBox.Size = new System.Drawing.Size(314, 20);
            this.filepathForCypherTextBox.TabIndex = 1;
            // 
            // messageForCypherTextBox
            // 
            this.messageForCypherTextBox.Location = new System.Drawing.Point(33, 89);
            this.messageForCypherTextBox.Multiline = true;
            this.messageForCypherTextBox.Name = "messageForCypherTextBox";
            this.messageForCypherTextBox.Size = new System.Drawing.Size(314, 55);
            this.messageForCypherTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Напишите фразу для кодирования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Шифровка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дешифровка";
            // 
            // filepathForDecypherTextBox
            // 
            this.filepathForDecypherTextBox.Enabled = false;
            this.filepathForDecypherTextBox.Location = new System.Drawing.Point(33, 208);
            this.filepathForDecypherTextBox.Name = "filepathForDecypherTextBox";
            this.filepathForDecypherTextBox.Size = new System.Drawing.Size(314, 20);
            this.filepathForDecypherTextBox.TabIndex = 11;
            // 
            // fileForDecypherTextBox
            // 
            this.fileForDecypherTextBox.Location = new System.Drawing.Point(357, 208);
            this.fileForDecypherTextBox.Name = "fileForDecypherTextBox";
            this.fileForDecypherTextBox.Size = new System.Drawing.Size(209, 23);
            this.fileForDecypherTextBox.TabIndex = 12;
            this.fileForDecypherTextBox.Text = "Выберите файл для дешифровки";
            this.fileForDecypherTextBox.UseVisualStyleBackColor = true;
            this.fileForDecypherTextBox.Click += new System.EventHandler(this.fileForDecypherTextBox_Click);
            // 
            // decypheredMessageTextBox
            // 
            this.decypheredMessageTextBox.Enabled = false;
            this.decypheredMessageTextBox.Location = new System.Drawing.Point(33, 252);
            this.decypheredMessageTextBox.Multiline = true;
            this.decypheredMessageTextBox.Name = "decypheredMessageTextBox";
            this.decypheredMessageTextBox.Size = new System.Drawing.Size(314, 67);
            this.decypheredMessageTextBox.TabIndex = 13;
            // 
            // decypherButton
            // 
            this.decypherButton.Enabled = false;
            this.decypherButton.Location = new System.Drawing.Point(357, 252);
            this.decypherButton.Name = "decypherButton";
            this.decypherButton.Size = new System.Drawing.Size(209, 23);
            this.decypherButton.TabIndex = 14;
            this.decypherButton.Text = "Дешифровать  сообщение";
            this.decypherButton.UseVisualStyleBackColor = true;
            this.decypherButton.Click += new System.EventHandler(this.decypherButton_Click);
            // 
            // cypherMessageButton
            // 
            this.cypherMessageButton.Enabled = false;
            this.cypherMessageButton.Location = new System.Drawing.Point(353, 108);
            this.cypherMessageButton.Name = "cypherMessageButton";
            this.cypherMessageButton.Size = new System.Drawing.Size(343, 23);
            this.cypherMessageButton.TabIndex = 15;
            this.cypherMessageButton.Text = "Зашифровать сообщение в файл";
            this.cypherMessageButton.UseVisualStyleBackColor = true;
            this.cypherMessageButton.Click += new System.EventHandler(this.cypherMessageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 340);
            this.Controls.Add(this.cypherMessageButton);
            this.Controls.Add(this.decypherButton);
            this.Controls.Add(this.decypheredMessageTextBox);
            this.Controls.Add(this.fileForDecypherTextBox);
            this.Controls.Add(this.filepathForDecypherTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageForCypherTextBox);
            this.Controls.Add(this.filepathForCypherTextBox);
            this.Controls.Add(this.chooseFileForCypherButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileForCypherButton;
        private System.Windows.Forms.TextBox filepathForCypherTextBox;
        private System.Windows.Forms.TextBox messageForCypherTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filepathForDecypherTextBox;
        private System.Windows.Forms.Button fileForDecypherTextBox;
        private System.Windows.Forms.TextBox decypheredMessageTextBox;
        private System.Windows.Forms.Button decypherButton;
        private System.Windows.Forms.Button cypherMessageButton;
    }
}

