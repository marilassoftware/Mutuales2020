using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Primarios
    {
        private string _strCodSpr;
        public string strCodSpr
        {
            get { return _strCodSpr; }
            set { _strCodSpr = value; }
        }

        private string _strNombreSpr;
        public string strNombreSpr
        {
            get { return _strNombreSpr; }
            set { _strNombreSpr = value; }
        }

        private int _intValorSpr;
        public int intValorSpr
        {
            get { return _intValorSpr; }
            set { _intValorSpr = value; }
        }

        private int _intValorCuotaSpr;
        public int intValorCuotaSpr
        {
            get { return _intValorCuotaSpr; }
            set { _intValorCuotaSpr = value; }
        }

        private int _intAñoSpr;
        public int intAñoSpr
        {
            get { return _intAñoSpr; }
            set { _intAñoSpr = value; }
        }

        private bool _bitUnicoSpr;
        public bool bitUnicoSpr
        {
            get { return _bitUnicoSpr; }
            set { _bitUnicoSpr = value; }
        }

        private string _strCodigoPar;
        public string strCodigoPar
        {
            get { return _strCodigoPar; }
            set { _strCodigoPar = value; }
        }

    }

    public partial class tblServiciosPrimario
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}
    }
}
