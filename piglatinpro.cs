/*
-----------------------------------------|SOLUTION |------------------------------------
BEZAO C# TASK 3

This program translate an English phrase to a Pig Latin Language.

P.S: This Solution was provided using Windows Forms Application

-----------------------------------------------------------------------------------------

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinTranslator
{
    public partial class Form1 : Form
    {
        const string appendingWord = "ay";
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultOftranslation = "";
            string input = textBox1.Text;

            string[] tempInput = input.Split(' ');

            for (int i = 0; i < tempInput.Length; i++)
            {
                resultOftranslation += PigLatinTranslation(tempInput[i]);
            }

            textBox2.Text = resultOftranslation;
     }

        private string PigLatinTranslation(string input)
        {
            string word;
            string firstLetter = input.Substring(0, 1);

            word = input.Substring(1) + firstLetter + appendingWord + " ";

            return word;
        }
    }
}
