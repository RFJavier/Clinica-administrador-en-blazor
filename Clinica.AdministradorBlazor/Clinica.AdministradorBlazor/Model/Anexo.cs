﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.AdministradorBlazor.Model
{
    public class Anexo
    {
        public int Id { get; set; }
        public int Idpaciente { get; set; }
        public string Anexos { get; set; }
    }
}
