using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RegistroArticulos.Entidades;
using RegistroArticulos.DAL;

namespace RegistroArticulos.BLL
{
    public class ArticulosBLL
    {

        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> expression)
        {
            List<Articulo> Libros = new List<Articulo>();
            Contexto contexto = new Contexto();
            try
            {
                Libros = contexto.Articulo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Libros;
        }


        public static bool Guardar(Articulo articulo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Articulo.Add(articulo) != null)
                {
                    db.SaveChanges();
                    paso = true;
                }

                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Modificar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Articulo articulo = contexto.Articulo.Find(id);
                contexto.Articulo.Remove(articulo);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static Articulo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulo articulo = new Articulo();

            try
            {
                articulo = contexto.Articulo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }


    }
}
