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
        /// <summary>
        /// En el manejador del evento carga, limpiamos todos los campos de texto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// En el manejador del cierre nos aseguramos que el usuario quiera salir, caso contrario sigue operando.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region ControlBotones
        /// <summary>
        /// Borra los campos de texto. Y pregunta si se quiere borrar la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            if (MessageBox.Show("Se han borrado los campos de operación y el resultado. ¿Desea borrar el historial de operaciones?",
                "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.lstOperaciones.Items.Clear();
            }
        }
       /// <summary>
       /// Ejecuta el cierre del formulario.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
        /// <summary>
        /// Ejecuta la operación solicitada, advierte la falta de operador, la falta de operando y el ingreso de texto como operando.
        /// También carga el resultado en el label y en el listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero1.Text, out double num1) || !double.TryParse(txtNumero2.Text, out double num2) || txtNumero1.Text == string.Empty || txtNumero2.Text == string.Empty)
            {
                MessageBox.Show("Operando incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.lstOperaciones.Items.Add("Ingreso invalido");
            }
            else
            {
                string auxOperar = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();

                if (auxOperar == double.MinValue.ToString())
                {
                    MessageBox.Show("Operación invalida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbOperador.Text == " ")
                {
                    MessageBox.Show("Por falta de operador, se ejecutara una suma ", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    this.lblResultado.Text = auxOperar;
                    this.lstOperaciones.Items.Add($"{txtNumero1.Text} + {txtNumero2.Text} = {auxOperar}");
                }
                else
                {
                    this.lblResultado.Text = auxOperar;
                    this.lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {auxOperar}");
                }
            }
        }
        /// <summary>
        /// Ejecuta la conversión, carga el label y la listbox con el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando decABin = new Operando();
            string auxDecABin = decABin.DecimalBinario(lblResultado.Text);
            this.lblResultado.Text = auxDecABin;
            this.lstOperaciones.Items.Add(auxDecABin);
        }
        /// <summary>
        /// Ejecuta la conversión, carga el label y la listbox con el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando binADec = new Operando();
            string auxBinADec = binADec.BinarioDecimal(lblResultado.Text);
            this.lblResultado.Text = auxBinADec;
            this.lstOperaciones.Items.Add(auxBinADec);
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Vacia el label, los campos de texto y el combobox.
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text = string.Empty;
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = 0;
        }
        /// <summary>
        /// Ejecuta la operación utilizando el Método Operar de la Clase Calculadora.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            return Calculadora.Operar(num1, num2, Convert.ToChar(operador));
        }
        #endregion
    }
}
