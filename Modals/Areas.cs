using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CrudNomina.Modals
{
    public class Areas
    {

        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string nombre_Area { get; set; }

    }
}
