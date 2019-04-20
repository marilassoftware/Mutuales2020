using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Devolucion
    {
        private int _intCodDeu;
        public int intCodDeu
        {
            get {return _intCodDeu;}
            set {_intCodDeu = value;}
        }

        private int _intCodigoSoc;
        public int intCodigoSoc
        {
            get { return _intCodigoSoc; }
            set { _intCodigoSoc = value; }
        }

        private string _strCodigoPar;
        public string strCodigoPar
        {
            get { return _strCodigoPar; }
            set { _strCodigoPar = value; }
        }

        private string _strCodSse;
        public string strCodSse
        {
            get { return _strCodSse; }
            set { _strCodSse = value; }
        }

        private bool _bitGlobalDeu;
        public bool bitGlobalDeu
        {
            get { return _bitGlobalDeu; }
            set { _bitGlobalDeu = value; }
        }

        private int _intAbonaDeu;
        public int intAbonaDeu
        {
            get { return _intAbonaDeu; }
            set { _intAbonaDeu = value; }
        }

        private int _intDebeDeu;
        public int intDebeDeu
        {
            get { return _intDebeDeu; }
            set { _intDebeDeu = value; }
        }
    }

    public partial class tblDevolucione
    {
        private tblLogdeActividade _log;
        public tblLogdeActividade log
        {
            get { return _log; }
            set { _log = value; }
        }

        string _strFormulario;
        public string strFormulario
        {
            get { return _strFormulario; }
            set { _strFormulario = value; }
        }
    }
}
