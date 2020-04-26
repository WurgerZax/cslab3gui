using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cslab3gui
{
    public partial class Form1 : Form
    {
        Matrix matrixA = new Matrix();
        Matrix matrixB = new Matrix();
        Matrix matrixD = new Matrix();

        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                matrixA.SetElement(Int32.Parse(textBox1.Text));
                matrixB.SetElement(Int32.Parse(textBox2.Text));
                NumElement.Text = $"Number of Element A( {matrixA.CurrentRow+1}, {matrixA.CurrentColumn+1})" +
                $" Number of Element B({ matrixB.CurrentRow + 1}, { matrixB.CurrentColumn + 1})";
            }
            catch(Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            matrixD = 3 * matrixB * matrixA + (matrixB - matrixA);
            display.Text = "A:\n"+matrixA.ToString()+"\nB:\n"+matrixB.ToString()+"\nD:\n"+matrixD.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
