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

namespace Steganography2
{
    public partial class Form1 : Form
    {
        public const string measure = "a";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new System.Windows.Forms.OpenFileDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.filepathForCypherTextBox.Text = dialog.FileName;
                    this.cypherMessageButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool checkIfEnoughRows()
        {
            try
            {
                int needBytesPerSymbol = System.Text.UTF8Encoding.UTF8.GetByteCount(measure);
                var lineCount = File.ReadLines(this.filepathForCypherTextBox.Text).Count();
                return (double)lineCount / (double)needBytesPerSymbol * (double)this.messageForCypherTextBox.Text.Length < 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void cypherMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = checkIfEnoughRows();
                if (result)
                {
                    MessageBox.Show("Недостаточно данных в контейнере для расшифровки");
                    return;
                }

                var byteRepresentationOfMessage = Encoding.UTF8.GetBytes(this.messageForCypherTextBox.Text);

                List<byte> array = new List<byte>();
                string[] binaryReprentationOfMessage = byteRepresentationOfMessage.Select(s => Convert.ToString(s, 2).PadLeft(8, '0')).ToArray();
                string joinedBinaryRepresentationOfMessage = string.Join("", binaryReprentationOfMessage);


                BitArray bitArray = new BitArray(byteRepresentationOfMessage);
                var stringFromContainer = File.ReadAllText(this.filepathForCypherTextBox.Text, Encoding.UTF8);

                #region impl2
                int position = 0;
                for (int i = 0; i < joinedBinaryRepresentationOfMessage.Length; i++)
                {
                    position = stringFromContainer.IndexOf(" ", position);
                    if(joinedBinaryRepresentationOfMessage.ElementAt(i).ToString() == "1")
                    {
                        stringFromContainer = stringFromContainer.Insert(position, " ");
                        position++;
                    }

                    position++;
                }
                #endregion

                File.WriteAllText(this.filepathForCypherTextBox.Text, stringFromContainer, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fileForDecypherTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new System.Windows.Forms.OpenFileDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.filepathForDecypherTextBox.Text = dialog.FileName;
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
            try
            {
                var stringFromFile = File.ReadAllText(this.filepathForDecypherTextBox.Text, Encoding.UTF8);
                Regex regexp = new Regex(@" +");
                var matches = regexp.Matches(stringFromFile).Cast<object>().Select(s => s.ToString());


                string binaryString = string.Empty;
                foreach(var x in matches)
                {
                    if (x.Length > 1) binaryString = binaryString + 1;
                    else { binaryString = binaryString + 0; }
                }

                List<Byte> byteList = new List<Byte>();

                for (int i = 0; i < binaryString.Length; i += 8)
                {
                    if (i + 8 > binaryString.Length) break;
                    byteList.Add(Convert.ToByte(binaryString.Substring(i, 8), 2));
                }

                this.decypheredMessageTextBox.Text = Encoding.UTF8.GetString(byteList.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
