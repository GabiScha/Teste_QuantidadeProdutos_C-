using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {

            double qntdis = Double.Parse( txtqntdis.Text);
            double qntdes = Double.Parse(txtqntdes.Text);
            double val = Double.Parse(txtval.Text);
            string form = lstpagamento.Text;
            double res = 0;

            if ( qntdes > 0 )
            {
                if ( qntdes < qntdis )
                {
                    switch (form)
                    { case "A vista":
                            res = qntdes * val;

                            txtres.Text = (res + "");
                      break;
                        case "2x Parcelado":
                            res = (qntdes * val) / 2;

                            txtres.Text = (res + "");
                            break;


                    }
                     
                }
                else
                {
                    MessageBox.Show(" Quantidade desejada maior do que o Estoque! ");
                }



            }
            else
            {
                MessageBox.Show(" Quantidade desejada INVALIDA!");
            }
        }
    }
}
