﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AplicacionWeb.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required (ErrorMessage = "Campo Requerido")]
        [StringLength(50,MinimumLength =3, ErrorMessage = "El nombre debe de tener de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage = "La descripcion no debe exceder los 256 caracteres")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
