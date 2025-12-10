using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entidades
{
    public class Nota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El contenido es obligatorio.")]
        [StringLength(1500, ErrorMessage = "El contenido no puede exceder los 1500 caracteres.")]
        public string Contenido {  get; set; }
    }
}
