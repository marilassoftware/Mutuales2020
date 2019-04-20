using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class ahorrosNavidenoIntereses
    {
        private string _strCedulaAho;
        public string strCedulaAho
        {
            get { return _strCedulaAho; }
            set { _strCedulaAho = value; }
        }

        private string _strNombreAho;
        public string strNombreAho
        {
            get { return _strNombreAho; }
            set { _strNombreAho = value; }
        }

        private double _fltAhorrosAho;
        public double fltAhorrosAho
        {
            get { return _fltAhorrosAho; }
            set { _fltAhorrosAho = value; }
        }

        private double _fltInteresAho;
        public double fltInteresAho
        {
            get { return _fltInteresAho; }
            set { _fltInteresAho = value; }
        }
    }
}
