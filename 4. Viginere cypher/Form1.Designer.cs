namespace _4.Viginere_cypher
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
            this.messageForCypherTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decypheredMessageTextBox = new System.Windows.Forms.TextBox();
            this.decypherButton = new System.Windows.Forms.Button();
            this.cypherMessageButton = new System.Windows.Forms.Button();
            this.deCypherKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cypherKeyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textForDecyperingTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageForCypherTextBox
            // 
            this.messageForCypherTextBox.Location = new System.Drawing.Point(33, 177);
            this.messageForCypherTextBox.Multiline = true;
            this.messageForCypherTextBox.Name = "messageForCypherTextBox";
            this.messageForCypherTextBox.Size = new System.Drawing.Size(314, 55);
            this.messageForCypherTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Напишите фразу для кодирования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Шифровка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дешифровка";
            // 
            // decypheredMessageTextBox
            // 
            this.decypheredMessageTextBox.Location = new System.Drawing.Point(33, 378);
            this.decypheredMessageTextBox.Multiline = true;
            this.decypheredMessageTextBox.Name = "decypheredMessageTextBox";
            this.decypheredMessageTextBox.Size = new System.Drawing.Size(314, 55);
            this.decypheredMessageTextBox.TabIndex = 13;
            // 
            // decypherButton
            // 
            this.decypherButton.Location = new System.Drawing.Point(360, 410);
            this.decypherButton.Name = "decypherButton";
            this.decypherButton.Size = new System.Drawing.Size(209, 23);
            this.decypherButton.TabIndex = 14;
            this.decypherButton.Text = "Дешифровать  сообщение";
            this.decypherButton.UseVisualStyleBackColor = true;
            this.decypherButton.Click += new System.EventHandler(this.decypherButton_Click);
            // 
            // cypherMessageButton
            // 
            this.cypherMessageButton.Location = new System.Drawing.Point(353, 134);
            this.cypherMessageButton.Name = "cypherMessageButton";
            this.cypherMessageButton.Size = new System.Drawing.Size(343, 23);
            this.cypherMessageButton.TabIndex = 15;
            this.cypherMessageButton.Text = "Зашифровать сообщение";
            this.cypherMessageButton.UseVisualStyleBackColor = true;
            this.cypherMessageButton.Click += new System.EventHandler(this.cypherMessageButton_Click);
            // 
            // deCypherKeyTextBox
            // 
            this.deCypherKeyTextBox.Location = new System.Drawing.Point(33, 343);
            this.deCypherKeyTextBox.Name = "deCypherKeyTextBox";
            this.deCypherKeyTextBox.Size = new System.Drawing.Size(314, 20);
            this.deCypherKeyTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Введите ключ для декодирования";
            // 
            // cypherKeyTextBox
            // 
            this.cypherKeyTextBox.Location = new System.Drawing.Point(36, 62);
            this.cypherKeyTextBox.Name = "cypherKeyTextBox";
            this.cypherKeyTextBox.Size = new System.Drawing.Size(311, 20);
            this.cypherKeyTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Введите ключ для кодирования";
            // 
            // textForDecyperingTextBox
            // 
            this.textForDecyperingTextBox.Location = new System.Drawing.Point(33, 281);
            this.textForDecyperingTextBox.Multiline = true;
            this.textForDecyperingTextBox.Name = "textForDecyperingTextBox";
            this.textForDecyperingTextBox.Size = new System.Drawing.Size(314, 46);
            this.textForDecyperingTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Зашифрованное сообщение";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(36, 105);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(311, 52);
            this.sourceTextBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Результат шифрования";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cypherKeyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deCypherKeyTextBox);
            this.Controls.Add(this.cypherMessageButton);
            this.Controls.Add(this.decypherButton);
            this.Controls.Add(this.decypheredMessageTextBox);
            this.Controls.Add(this.textForDecyperingTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageForCypherTextBox);
            this.Name = "Form1";
            this.Text = "Программа для шифровки/дешифровки сообщения с помощью шифра Вижинера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox messageForCypherTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decypheredMessageTextBox;
        private System.Windows.Forms.Button decypherButton;
        private System.Windows.Forms.Button cypherMessageButton;
        private System.Windows.Forms.TextBox deCypherKeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cypherKeyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textForDecyperingTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label label6;
    }
}

