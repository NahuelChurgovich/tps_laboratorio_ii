using System;
using System.Windows.Forms;

using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {

            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            if (MessageBox.Show("Se han borrado los campos de operación y el resultado. ¿Desea borrar el historial de operaciones?",
                "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.lstOperaciones.Text = string.Empty;
            }
        }

        private void Limpiar()
        {
            this.lblResultado.Text = string.Empty;
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            return Calculadora.Operar(num1, num2, Convert.ToChar(operador));
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string auxOperar = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            if (auxOperar == double.MinValue.ToString())
            {
                MessageBox.Show("Operación invalida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.lblResultado.Text = auxOperar;
                this.lstOperaciones.Items.Add(auxOperar);
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando decABin = new Operando();
            string auxDecABin = decABin.DecimalBinario(lblResultado.Text);
            this.lblResultado.Text = auxDecABin;
            this.lstOperaciones.Items.Add(auxDecABin);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando binADec = new Operando();
            string auxBinADec = binADec.BinarioDecimal(lblResultado.Text);
            this.lblResultado.Text = auxBinADec;
            this.lstOperaciones.Items.Add(auxBinADec);
        }


    }
}
