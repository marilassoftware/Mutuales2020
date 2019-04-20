using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class creditosTipo
    {
        private string _strCodigoTcr;
        public string strCodigoTcr
        {
            get { return _strCodigoTcr; }
            set { _strCodigoTcr = value; }
        }

        private string _strDescripcionTcr;
        public string strDescripcionTcr
        {
            get { return _strDescripcionTcr; }
            set { _strDescripcionTcr = value; }
        }

        private decimal _decTasaEfectivaAnualBasicaTcr;
        public decimal decTasaEfectivaAnualBasicaTcr
        {
            get { return _decTasaEfectivaAnualBasicaTcr; }
            set { _decTasaEfectivaAnualBasicaTcr = value; }
        }

        private decimal _decTasaNominalAnualBasicaTcr;
        public decimal decTasaNominalAnualBasicaTcr
        {
            get { return _decTasaNominalAnualBasicaTcr; }
            set { _decTasaNominalAnualBasicaTcr = value; }
        }

        private decimal _decTasaNominalAnualBasicaSemanalTcr;
        public decimal decTasaNominalAnualBasicaSemanalTcr
        {
            get { return _decTasaNominalAnualBasicaSemanalTcr; }
            set { _decTasaNominalAnualBasicaSemanalTcr = value; }
        }

        private decimal _decTasaNominalAnualBasicaDecadalTcr;
        public decimal decTasaNominalAnualBasicaDecadalTcr
        {
            get { return _decTasaNominalAnualBasicaDecadalTcr; }
            set { _decTasaNominalAnualBasicaDecadalTcr = value; }
        }

        private decimal _decTasaNominalAnualBasicaQuincenalTcr;
        public decimal decTasaNominalAnualBasicaQuincenalTcr
        {
            get { return _decTasaNominalAnualBasicaQuincenalTcr; }
            set { _decTasaNominalAnualBasicaQuincenalTcr = value; }
        }

        private decimal _decTasaNominalAnualBasicaMensualTcr;
        public decimal decTasaNominalAnualBasicaMensualTcr
        {
            get { return _decTasaNominalAnualBasicaMensualTcr; }
            set { _decTasaNominalAnualBasicaMensualTcr = value; }
        }

        private decimal _decTasaEfectivaAnualUsuraTcr;
        public decimal decTasaEfectivaAnualUsuraTcr
        {
            get { return _decTasaEfectivaAnualUsuraTcr; }
            set { _decTasaEfectivaAnualUsuraTcr = value; }
        }

        private decimal _decTasaNominalAnualUsuraTcr;
        public decimal decTasaNominalAnualUsuraTcr
        {
            get { return _decTasaNominalAnualUsuraTcr; }
            set { _decTasaNominalAnualUsuraTcr = value; }
        }

        private decimal _decTasaNominalAnualUsuraSemanalTcr;
        public decimal decTasaNominalAnualUsuraSemanalTcr
        {
            get { return _decTasaNominalAnualUsuraSemanalTcr; }
            set { _decTasaNominalAnualUsuraSemanalTcr = value; }
        }

        private decimal _decTasaNominalAnualUsuraDecadalTcr;
        public decimal decTasaNominalAnualUsuraDecadalTcr
        {
            get { return _decTasaNominalAnualUsuraDecadalTcr; }
            set { _decTasaNominalAnualUsuraDecadalTcr = value; }
        }

        private decimal _decTasaNominalAnualUsuraQuincenalTcr;
        public decimal decTasaNominalAnualUsuraQuincenalTcr
        {
            get { return _decTasaNominalAnualUsuraQuincenalTcr; }
            set { _decTasaNominalAnualUsuraQuincenalTcr = value; }
        }

        private decimal _decTasaNominalAnualUsuraMensualTcr;
        public decimal decTasaNominalAnualUsuraMensualTcr
        {
            get { return _decTasaNominalAnualUsuraMensualTcr; }
            set { _decTasaNominalAnualUsuraMensualTcr = value; }
        }

    }

    public partial class tblCreditosTipo
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}
    }
}
