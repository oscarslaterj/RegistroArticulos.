using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroArticulos.Entidades;
using RegistroArticulos.BLL;
using RegistroArticulos.DAL;

namespace RegistroArticulos.UI.Consultas
{
    public partial class RegistroArticulo : Form
    {
        public RegistroArticulo()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty; ;
            ExistenciatextBox.Text = string.Empty;
            CantidadCotizadanumericUpDown.Value = 0;
        }

        private Articulo LlenaClase()
        {
            Articulo articulo = new Articulo();
            articulo.ArticuloId = Convert.ToInt32(IDnumericUpDown.Value);
            articulo.Descripcion = DescripciontextBox.Text;
            articulo.Precio = PreciotextBox.Text;
            articulo.Existencia = ExistenciatextBox.Text;
            articulo.CantidadCotizada = Convert.ToInt32(CantidadCotizadanumericUpDown.Value);
            return articulo;
        }

        //Validando Textbox para que permita solo numeros
        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
                MessageBox.Show("Introducir solo numeros", "Aviso", MessageBoxButtons.OK);
            }
        }


        private bool ExiteEnBaseDeDatos()
        {
            Articulo articulo = ArticulosBLL.Buscar((int)IDnumericUpDown.Value);
            return (articulo != null);
        }

        private bool Validar()
        {
            bool paso = true;


            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
                errorProvider.SetError(DescripciontextBox, "No dejar campo vacio");


            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
                errorProvider.SetError(PreciotextBox, "No dejar campo vacio");


            if (string.IsNullOrWhiteSpace(ExistenciatextBox.Text))
                errorProvider.SetError(ExistenciatextBox, "No dejar campo vacio");

            paso = false;

            return paso;
        }


        private void LlenaCampo(Articulo articulo)
        {
            IDnumericUpDown.Value = articulo.ArticuloId;
            DescripciontextBox.Text = articulo.Descripcion;
            ExistenciatextBox.Text = articulo.Existencia;
            PreciotextBox.Text = articulo.Precio;
            CantidadCotizadanumericUpDown.Value = articulo.CantidadCotizada;

        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Articulo articulo = new Articulo();
            int.TryParse(IDnumericUpDown.Text, out id);
            articulo = ArticulosBLL.Buscar(id);
            if (articulo != null)
            {
                LlenaCampo(articulo);
                MessageBox.Show("Articulo  Encotrado");


            }
            else
            {
                MessageBox.Show("Articulo no Encotrado");

            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           Articulo articulo;
            bool paso = false;

            if (!Validar())
                return;



            articulo = LlenaClase();
            if (IDnumericUpDown.Value == 0)
            {

                paso = ArticulosBLL.Guardar(articulo);
            }
            else
            {
                if (!ExiteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar  un articulo que no exite", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ArticulosBLL.Modificar(articulo);

            }
            Limpiar();
            if (paso)
                MessageBox.Show("Guardado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("No  se pudo Guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if (ArticulosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
                Limpiar();
            }
            else
                MessageBox.Show("no se pudo eliminar");
        }
        
        //Validando Textbox para que permita solo numeros
        private void ExistenciatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
                MessageBox.Show("Introducir solo numeros", "Aviso", MessageBoxButtons.OK);
            }
        }
    }
}
