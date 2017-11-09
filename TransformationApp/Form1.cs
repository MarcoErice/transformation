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
using TransformationLib;

namespace TransformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirstFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var firstFile = File.ReadAllLines(openFileDialog1.FileName);
            string[] lines = firstFile;
            listBox1.Items.AddRange(lines);
        }

        private void btnSecondFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            var secondFile = File.ReadAllLines(openFileDialog2.FileName);
            string[] lines = secondFile;
            listBox2.Items.AddRange(lines);
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string amountContent = File.ReadAllText(openFileDialog1.FileName);
            string quantityContent = File.ReadAllText(openFileDialog2.FileName);
            var result = Transformation.Transform(amountContent, quantityContent);
            File.WriteAllText(saveFileDialog1.FileName, result);
        }
    }
}
