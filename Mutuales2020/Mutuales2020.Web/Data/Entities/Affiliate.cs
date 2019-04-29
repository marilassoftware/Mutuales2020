namespace Mutuales2020.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Affiliate
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Código")]
        [Required]
        public int intCodigoAfi { get; set; }

        [Display(Name = "Cédula")]
        [MaxLength(30)]
        [Required]
        public String strCedulaAfi { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100)]
        [Required]
        public String strNombreAfi { get; set; }

        [Display(Name = "Apellido 1")]
        [MaxLength(100)]
        [Required]
        public String strApellido1Afi { get; set; }

        [Display(Name = "Apellido 2")]
        [MaxLength(100)]
        [Required]
        public String strApellido2Afi { get; set; }

        [Display(Name = "Plan")]
        [MaxLength(50)]
        [Required]
        public String strPlanAfi { get; set; }

        [Display(Name = "Año")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
        [Required]
        public int intAnoAfi { get; set; }

        [Display(Name = "Mes")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
        [Required]
        public int intMesAfi { get; set; }

        [Display(Name = "Ultima Actualización")]
        [Required]
        public DateTime dtmFechaActualizacion { get; set; }

        [Display(Name = "Mutual")]
        [Required]
        public String strCodigoMut { get; set; }
    }
}
