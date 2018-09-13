using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroArticulos.Entidades
{
    public class Articulo
    {
        [Key]

        public int ArticuloId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public String Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public int CantidadCotizada { get; set; }

        public Articulo()
        {
            ArticuloId = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = string.Empty;
            Precio = 0;
            Existencia = 0;
            CantidadCotizada = 0;
        }
        
    }
}
