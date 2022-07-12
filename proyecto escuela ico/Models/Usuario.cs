﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proyecto_escuela_ico.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
   
        public string Correo { get; set; }

        public string Clave { get; set; }

        public string ConfirmarClave { get; set; }
    }
}