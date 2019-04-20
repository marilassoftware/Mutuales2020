using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class semana
    {
        public int intCodigoSem {get ; set;}

        public string dtmFechaSem  {get ; set;}

        public int intAño { get; set; }

        public string strTipo { get; set; }
    }

    public partial class tblSemana
    {
        public tblLogdeActividade log  {get ; set;}

        public string strFormulario  {get ; set;}
    }
}
