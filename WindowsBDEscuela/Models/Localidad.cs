using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Localidad")]
    public class Localidad
    {
        public int LocalidadId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de navegacion

        public List<Profesor> Profesores { get; set; }
        public List<Estudiante> Estudiantes { get; set; }

        #endregion
    }
}
