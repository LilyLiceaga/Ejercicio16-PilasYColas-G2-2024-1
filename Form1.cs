using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio16_PilasYColas_G2_2024_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        static void Cola(object txtbPalindromos)
        {
            Queue<String> FraseInicial = new Queue<String>();

            txtbPalindromos = char.Parse(txtbPalindromos.ToString().ToLower());
            
            int total = FraseInicial.Count; 
            for (int i = 0; i < total; i++)
            {

            }
        }
        static void Pila()
        {
            Stack<String> FraseReversa = new Stack<String>();

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ()
            {
                lbFrase.Text = "Es un Palindromo!";
            }
            else
            {
                lbFrase.Text = "No es un Palindromo!";
            }
        }

        private void txtbPalindromos_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
