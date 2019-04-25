namespace Mutuales2020.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Affiliate
    {
        public int Id { get; set; }

        [Display(Name = "Código")]
        [Required]
        public int intCodigoSoc { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100)]
        [Required]
        public String strNombreAfi { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(100)]
        [Required]
        public String strApellidoAfi { get; set; }

        [Display(Name = "Año")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
        [Required]
        public int intAnoAfi { get; set; }

        [Display(Name = "Mes")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
        [Required]
        public int intMesAfi { get; set; }

        [Display(Name = "Mutual")]
        [Required]
        public String strCodigoMut { get; set; }
    }
}
