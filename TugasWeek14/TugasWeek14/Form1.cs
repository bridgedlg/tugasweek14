using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonkonversi_Click(object sender, EventArgs e)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            char[] alphachar = new char[alpha.Length];
            char[] charkalimat = new char[textkalimat.TextLength];
            char[] texthuruf = new char[textboxhuruf.TextLength];
            char[] texthuruf2 = new char[textboxjadi.TextLength];
            string result = "";
            int key = 0;
            int counter1 = 0;
            int counter2 = 0;
            for(int i=0; i<alphachar.Length; i++)
            {
               if (texthuruf.Equals(alphachar[i]))
                { counter1 = i; }

               if(texthuruf2.Equals(alphachar[i]))
                {
                    counter2 = i;
                
                }
                    
            }

            if(counter2>counter1)
            {
                key = counter2 - counter1;
            }

            else
            { 
                
                key = counter2 + 26 - counter1; 
            
            }

            for(int i=0; i<charkalimat.Length; i++)
            {
                if (charkalimat[i].Equals(""))
                { result = result + " "; }

                else
                {
                    for(int j=0; j<alphachar.Length; j++)
                    { 
                        if(charkalimat[i].Equals(alphachar[j]))
                        { 
                         if(j+key<26)
                            {
                                result = result + alphachar[j + key];
                            }
                         else
                            {
                                result = result + alphachar[j + key - 26];
                            }
                        }  
                     }
                }
                
            }
            labelhasil.Text = result;

        }
    }
}
