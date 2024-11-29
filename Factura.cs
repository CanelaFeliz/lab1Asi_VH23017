using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Asi_VH23107
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        public void SetFacturaInfo(string Cliente, int ingredientesExtra, bool tipo)
        {
            lbdSalidaCliente.Text = Cliente;
            lbdSalidaIngredientes.Text = Convert.ToString(ingredientesExtra);


            if (tipo == true)
            {
                //submarino pequeño
                double precioSub = 5;
                if(ingredientesExtra == 1)
                {
                    precioSub = precioSub;
                }
                else if (ingredientesExtra == 1)
                {
                    precioSub = precioSub + 1;
                }
                else if (ingredientesExtra > 1 && ingredientesExtra < 4)
                {
                    precioSub = precioSub + ingredientesExtra * 0.75;
                }
                else if (ingredientesExtra == 4)
                {
                    precioSub = precioSub + ingredientesExtra * 0.5;
                }
                else if (ingredientesExtra > 4)
                {
                    precioSub = precioSub + ingredientesExtra * 0.25;
                }
                lbdSalidaTotal.Text = Convert.ToString(precioSub);
                lbdSalidaSubmarino.Text = "Pequeño";
            }
            else
            {
                //submarino grande
                double precioSub = 7;
                if (ingredientesExtra == 1)
                {
                    precioSub = precioSub;
                }
                else if (ingredientesExtra == 1)
                {
                    precioSub = precioSub + 1.5;
                }
                else if (ingredientesExtra > 1 && ingredientesExtra < 4)
                {
                    precioSub = precioSub + ingredientesExtra * 1;
                }
                else if (ingredientesExtra == 4)
                {
                    precioSub = precioSub + ingredientesExtra * 0.5;
                }
                else if (ingredientesExtra > 4)
                {
                    precioSub = precioSub + ingredientesExtra * 0.25;
                }
                

                lbdSalidaTotal.Text = Convert.ToString(precioSub);
                lbdSalidaSubmarino.Text = "Grande";
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
