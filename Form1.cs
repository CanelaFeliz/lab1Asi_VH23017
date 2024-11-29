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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtIngredientesExtra.Clear();
            rbtPequeno.Checked = false;
            rbtGrande.Checked = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string Cliente;
        int ingrdientesExtra;
        bool tipo = true;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrEmpty(txtIngredientesExtra.Text))
            {
                MessageBox.Show("Por favor llene los campos");
            }
            else if (!int.TryParse(txtIngredientesExtra.Text, out ingrdientesExtra))
            {
                txtIngredientesExtra.Clear();
                MessageBox.Show("Ingrese un valor válido");
            }
            else if (rbtPequeno.Checked == false && rbtGrande.Checked == false)
            {
                MessageBox.Show("Por favor seleccione un tipo de submarino");
            }
          else
            {
                    if (rbtPequeno.Checked == true)
                {
                    tipo = true;
                }
                    else
                {
                    tipo = false;
                }

                    Cliente = txtCliente.Text;
                    ingrdientesExtra = int.Parse(txtIngredientesExtra.Text);

                    Factura facturaForm = new Factura();
                    facturaForm.SetFacturaInfo(Cliente, ingrdientesExtra, tipo);
                    facturaForm.ShowDialog();
             }
            }
        }
    }
