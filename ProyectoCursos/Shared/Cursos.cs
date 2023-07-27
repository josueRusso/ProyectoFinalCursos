﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoCursos.Shared
{
    public class Cursos
    {
        [Key]
        public int CursoId { get; set; }

        [Required(ErrorMessage = "* El campo Nombre  es obligatorio")]
        public string NombreCurso { get; set; }

        [Required(ErrorMessage = "* El campo Descripcion  es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "* El campo Ruta Imagen es obligatorio")]
        public string? RutaImagen { get; set; }

        [Required(ErrorMessage = "* El campo Fecha Inicio es obligatorio")]
        public DateTime FechaAlta { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "* El campo Programa es obligatorio")]
        public string Programa { get; set; }

        [Required(ErrorMessage = "* El campo fecha Fin es obligatorio")]
        public DateTime FechaBaja { get; set; } = DateTime.Now;

        [ForeignKey(("CursoId"))]
        public ICollection<PreciosDetalle> PreciosDetalle { get; set; } = new List<PreciosDetalle>();

    }
}
