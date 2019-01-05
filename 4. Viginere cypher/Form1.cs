using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Viginere_cypher
{
    public partial class Form1 : Form
    {
        public const string russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public Form1()
        {
            InitializeComponent();
        }


        private void cypherMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                string cypher = CreateCypheredText(this.sourceTextBox.Text, this.cypherKeyTextBox.Text);
                this.messageForCypherTextBox.Text = cypher;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string CreateCypheredText(string text, string key)
        {

            string cypheredText = string.Empty;
                string[] matrix = CreateMatrix();
                List<Tuple<string, string>> list = new List<Tuple<string, string>>();
                for (int i = 0, keyCounter = 0; i < text.Length; i++)
                {
                    if (russianAlphabet.ToLower().Contains(text[i].ToString().ToLower()))
                    {
                        if (keyCounter == key.Length) keyCounter = 0;
                        list.Add(Tuple.Create(text[i].ToString(), key[keyCounter].ToString()));
                        keyCounter++;
                    }
                    else
                    {
                        list.Add(Tuple.Create(text[i].ToString(), text[i].ToString()));
                    }
                }


                for (int i = 0; i < list.Count; i++)
                {
                    if(!russianAlphabet.Contains(list[i].Item1.ToLower()))
                    {
                        cypheredText += list[i].Item1;
                        continue;
                    }
                    int indexOfMainRow = russianAlphabet.IndexOf(list[i].Item1.ToLower());
                    int indexOfAdditionalRow = 0;

                        for (int k = 0; k < matrix.Length; k++)
                        {
                            var sdfsf = matrix[k][0].ToString();
                            if (sdfsf == list[i].Item2.ToLower())
                            {
                                indexOfAdditionalRow = k;
                            }
                        }


                    cypheredText += matrix[indexOfAdditionalRow][indexOfMainRow];
                        
                }
            

            return cypheredText;
        }

        private string[] CreateMatrix()
        {
            string[] matrix = new string[russianAlphabet.Length];
            StringBuilder sb = new StringBuilder(russianAlphabet);
            matrix[0] = russianAlphabet;
            for(int i = 1; i < russianAlphabet.Length; i++)
            {
                sb = new StringBuilder(matrix[i - 1]);
                sb.Append(sb[0]);
                sb.Remove(0, 1);
                matrix[i] = sb.ToString();
            }

            return matrix;
        }


        private void fileForDecypherTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new System.Windows.Forms.OpenFileDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.textForDecyperingTextBox.Text = dialog.FileName;
                    this.decypherButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void decypherButton_Click(object sender, EventArgs e)
        {
            try {

                this.decypheredMessageTextBox.Text = GetDecypheredText(this.textForDecyperingTextBox.Text, this.deCypherKeyTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string GetDecypheredText(string text, string key)
        {
            string cypheredText = string.Empty;
            string[] matrix = CreateMatrix();
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            for (int i = 0, keyCounter = 0; i < text.Length; i++)
            {
                if (russianAlphabet.Contains(text[i].ToString().ToLower()))
                {
                    if (keyCounter == key.Length) keyCounter = 0;
                    list.Add(Tuple.Create(text[i].ToString(), key[keyCounter].ToString()));
                    keyCounter++;
                }
                else
                {
                    list.Add(Tuple.Create(text[i].ToString(), text[i].ToString()));
                }
            }


            for (int i = 0; i < list.Count; i++)
            {
                if (!russianAlphabet.Contains(list[i].Item1.ToLower()))
                {
                    cypheredText += list[i].Item1;
                    continue;
                }
                int indexOfAdditionalRow = 0;

                for (int k = 0; k < matrix.Length; k++)
                {
                    var sdfsf = matrix[k][0].ToString();
                    if (sdfsf == list[i].Item2.ToLower())
                    {
                        indexOfAdditionalRow = k;
                    }
                }

                int indexOfLetterInAdditionalRow = matrix[indexOfAdditionalRow].IndexOf(list[i].Item1.ToLower());

                cypheredText += matrix[0][indexOfLetterInAdditionalRow];

            }


            return cypheredText;
        }
    }
}
