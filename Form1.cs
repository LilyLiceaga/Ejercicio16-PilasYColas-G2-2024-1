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
        
        private void btnAceptar_Click(object sender, EventArgs e )
        {
            string palindromo = txtbPalindromos.Text.ToLower().Replace(" ", ""); ;

            Queue<char> FraseInicial = new Queue<char>();
            Stack<char> FraseReversa = new Stack<char>();

            int frase = 0;
            int total = palindromo.Length; 
            char[] array = palindromo.ToCharArray();


            for (int i = 0; i < total; i++)
            {
                FraseInicial.Enqueue(palindromo[i]);
                FraseReversa.Push(palindromo[i]);
            } 
            
            for (int i = 0; i < total; i++)
            {
                if (FraseInicial.Dequeue() == FraseReversa.Pop())
                {
                    frase += 1;
                }
                else
                {
                    frase = 0;
                }
            }

            if (frase == total)
            {
                lbFrase.Text = "Es un Palindromo!";
            }
            else
            {
                lbFrase.Text = "No es un Palindromo!";
            }
        }
    }
}
