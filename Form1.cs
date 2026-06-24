using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTaquillaDeCine
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //capturamos nombre
            string name = txtNombre.Text;
            //Creacion de objeto 
            clsBoleto boleto = null;
            // Verificacion del combobox
            if(cmbTipoBoleto.Text == "Estudiante")
            {                
                boleto = new clsEstudiante(txtTipo.Text);
            }


            //Verificacion que el objeto no quede nulo para proceder a calcular
            if(boleto!= null)
            {
                double total = boleto.CalcularBoletoFinal();
                MessageBox.Show("Bienvenido " + name + " del tipo " + cmbTipoBoleto.Text + 
                    "\nEl total del pago es: " + total);
                lblCalculo.Text = "Total a pagar: $" + total;
            }
        }

        private void cmbTipoBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoBoleto.Text == "Estudiante")
            {
                lblTipoUsuario.Visible = true;
                txtTipo.Visible = true;
                lblTipoUsuario.Text = "Ingrese su matricula escolar:";
            }
            else if(cmbTipoBoleto.Text == "Adulto Mayor")
            {
                lblTipoUsuario.Text = "Ingrese su inapam";
            }
            else
            {
                lblTipoUsuario.Visible = false;
                txtTipo.Visible = false;
                txtTipo.Clear();
            }
        }
    }
}
