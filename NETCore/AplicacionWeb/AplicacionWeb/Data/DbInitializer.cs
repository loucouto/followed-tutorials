using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacionWeb.Models;

namespace AplicacionWeb.Data
{
    public class DbInitializer
    {
        public static void Initialize(AplicacionWebContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre = "Programacion", Descripcion = "Curso de Programacion", Estado = true },
                 new Categoria{Nombre = "Diseño grafico", Descripcion = "Curso de diseño grafico", Estado = true }
            };

            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }

            context.SaveChanges();
        }
    }
}
