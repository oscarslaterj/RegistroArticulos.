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

namespace RegistroArticulos.UI.Consultas
{
    public partial class ConsultaArticulos : Form
    {
        public ConsultaArticulos()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            {
                var listado = new List<Articulo>();

                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.SelectedIndex)
                    {

                        case 0://Todo
                            listado = ArticulosBLL.GetList(p => true);
                            break;
                        case 1://ID
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = ArticulosBLL.GetList(p => p.ArticuloId == id);
                            break;

                        case 2://Descripcion
                            listado = ArticulosBLL.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                            break;
                        case 3://Precio
                            listado = ArticulosBLL.GetList(p => p.Precio.Contains(CriteriotextBox.Text));
                            break;
                        case 4://Existencia
                            listado = ArticulosBLL.GetList(p => p.Existencia.Contains(CriteriotextBox.Text));
                            break;
                    }

                    listado = listado.Where(c => c.FechaVencimiento.Date >= DesdedateTimePicker.Value.Date && c.FechaVencimiento.Date <= HastadateTimePicker.Value.Date).ToList();
                }
                else
                {
                    listado = ArticulosBLL.GetList(p => true);
                }


                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = listado;
            }

        }
    }
}
