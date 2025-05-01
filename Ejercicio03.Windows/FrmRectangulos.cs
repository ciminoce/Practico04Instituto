using Ejercicio03.Entidades;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ejercicio03.Windows
{
    public partial class FrmRectangulos : Form
    {
        public FrmRectangulos()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            TxtAnchura.Clear();
            TxtLongitud.Clear();
            TxtAnchura.Focus();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var anchura=int.Parse(TxtAnchura.Text);
                var longitud = int.Parse(TxtLongitud.Text);
                Rectangulo r = new Rectangulo(anchura, longitud);

                var context = new ValidationContext(r);
                var errors=new List<ValidationResult>();

                var isValid = Validator.TryValidateObject(r, context, errors, true);
                if (isValid)
                {
                    MessageBox.Show(r.ToString(), "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    AgregarRectangulo(r);
                    InicializarControles();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var error in errors)
                    {
                        sb.AppendLine($"{error.ErrorMessage}");
                    }
                    MessageBox.Show(sb.ToString(), "Errores", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    TxtAnchura.SelectAll();
                    TxtAnchura.Focus();
                }
            }
        }

        private void AgregarRectangulo(Rectangulo r)
        {
            LstRectangulos.Items.Add(r.MostrarInfo());
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(TxtAnchura.Text,out _))
            {
                valido = false;
                errorProvider1.SetError(TxtAnchura, "Anchura mal ingresada");
            }
            if (!int.TryParse(TxtLongitud.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(TxtLongitud, "Longitud mal ingresada");
            }
            return valido;
        }
    }
}
