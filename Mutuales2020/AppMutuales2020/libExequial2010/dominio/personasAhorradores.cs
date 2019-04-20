using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Ahorrador
    {
        private int _intCodigoSoc;
        public int intCodigoSoc
        {
            get { return _intCodigoSoc; }
            set { _intCodigoSoc = value; }
        }

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

        private string _strApellidoAho;
        public string strApellidoAho
        {
            get { return _strApellidoAho; }
            set { _strApellidoAho = value; }
        }


        private string _strTelefono;
        public string strTelefono
        {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }

        private string _strDireccion;
        public string strDireccion
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }
    }

    public partial class tblAhorradore
    {
        public tblLogdeActividade log{get;set;}

        public string strFormulario{get;set;}
    }

    /// <summary> Almacena el monto por el que debe de reporder la mutual por cada item del ahorro. </summary>
    public partial class ahorrorosRegistrados
    {
        /// <summary> Almacena el total en ahorros a la vista. </summary>
        public decimal decAhorroalaVista { get; set; }
        /// <summary> Almacena el total en ahorros estudiantiles. </summary>
        public decimal decAhorroEstudiantil { get; set; }
        /// <summary> Almacena el total en ahorros a futuro. </summary>
        public decimal decAhorroaFuturo { get; set; }
        /// <summary> Almacena el total en ahorros navideños. </summary>
        public decimal decAhorroNavideño { get; set; }
        /// <summary> Almacena el total en ahorros escolares. </summary>
        public decimal decAhorroNatilleraEscolar { get; set; }
        /// <summary> Almacena el total en ahorros fijos. </summary>
        public decimal decAhorroFijo { get; set; }
        /// <summary> Almacena el total en ahorros CDAT. </summary>
        public decimal decAhorroCdta { get; set; }
        /// <summary> Almacena el total de los ahorros. </summary>
        public decimal decTotales { get; set; }

    }

}
