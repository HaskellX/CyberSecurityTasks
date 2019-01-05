using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Antivirus_search
{
    public partial class Form1 : Form
    {
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
                    this.targetFileTextBox.Text = dialog.FileName;
                    this.offsetTextBox.Enabled = true;
                    this.lengthTextBox.Enabled = true;
                    this.searchButton.Enabled = true;

                    var myfile = File.ReadAllBytes(targetFileTextBox.Text);
                    this.limitLabel.Text = "Лимит " + myfile.Length;
                    this.limitLabel.Visible = true;
                    this.searchButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            try
            {
                int offset = int.Parse(offsetTextBox.Text);
                int length = int.Parse(this.lengthTextBox.Text);

                var allFiles = Directory.GetFiles(this.selectedFolderTextBox.Text, "*.*", SearchOption.AllDirectories);

                var myFile = File.ReadAllBytes(this.targetFileTextBox.Text);
                var myExtract = myFile.Skip(offset).Take(length).ToArray();

                var foundFiles = new List<string>();

                foreach (var x in allFiles)
                {
                    var targetFile = File.ReadAllBytes(x);
                    if (targetFile.Intersect(myExtract).Any())
                    {
                        foundFiles.Add(x);
                    }
                }

                this.resultsListBox.DataSource = foundFiles.Distinct().ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.selectedFolderTextBox.Text = dialog.SelectedPath;
                    this.offsetTextBox.Enabled = true;
                    this.lengthTextBox.Enabled = true;
                    this.searchButton.Enabled = true;

                    this.limitLabel.Visible = true;
                    this.searchButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
