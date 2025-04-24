using Ejercicio01.Entidades;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ejercicio01.Windows
{
    public partial class FrmCuadrado : Form
    {
        public FrmCuadrado()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            InicializarTexto();
        }

        private void InicializarTexto()
        {
            TxtLado.Clear();
            TxtLado.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var c = new Cuadrado()
                {
                    Lado = double.Parse(TxtLado.Text)
                };
                var context = new ValidationContext(c);
                var errores = new List<ValidationResult>();
                bool esValido = Validator.TryValidateObject(c, context, errores, true);
                if (esValido)
                {
                    MessageBox.Show(c.ImprimirInformacion(), "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LstCuadrados.Items.Add(c);
                    InicializarTexto();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    StringBuilder sbErrores = new StringBuilder();
                    foreach (var item in errores)
                    {
                        sbErrores.AppendLine(item.ErrorMessage);
                    }

                    MessageBox.Show(sbErrores.ToString(),
                        "Errores", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    TxtLado.SelectAll();
                    TxtLado.Focus();
                }
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!double.TryParse(TxtLado.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(TxtLado, "Lado mal ingresado");
            }
            return valido;
        }
    }
}
