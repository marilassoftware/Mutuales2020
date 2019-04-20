using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using libMutuales2020.dominio;
using libMutuales2020.dao;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blAhorrosCdt
    {
        /// <summary> Inserta un cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro cdt. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosCdt tobjAhorroCdt)
        {
            if (tobjAhorroCdt.dtmFechaIniCdt == null)
                return "- Debe de ingresar la fecha  de apertura del Cdt. ";

            if (Convert.ToDateTime(tobjAhorroCdt.dtmFechaIniCdt.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                return "- La fecha del cdt no debe ser inferior a la fecha actual. ";

            if (tobjAhorroCdt.decInteresesCdt == 0)
                return "- Debe de ingresar los intereses para el Cdt. ";

            if (tobjAhorroCdt.intMesesCdt == 0)
                return "- Debe de ingresar los meses de duración del Cdt";

            if (tobjAhorroCdt.decMontoCdt == 0)
                return "- Debe de ingresar el monto del Cdt.";

            if (tobjAhorroCdt.intNumeroCdt == 0)
                return "- Debe de ingresar el código del Cdt.";

            if (tobjAhorroCdt.strCedulaAho == null || tobjAhorroCdt.strCedulaAho.Trim() == "")
                return "- Debe de ingresar la cédula del ahorrador del Cdt.";

            tobjAhorroCdt.decInteresMensualCdt = (tobjAhorroCdt.decInteresesCdt / 12) * tobjAhorroCdt.intMesesCdt;

            tobjAhorroCdt.decValorIntereses = tobjAhorroCdt.decMontoCdt * (tobjAhorroCdt.decInteresesCdt / 100);

            tobjAhorroCdt.log = metodos.gmtdLog("Ingresa el Cdt.  " + tobjAhorroCdt.intNumeroCdt.ToString(), tobjAhorroCdt.strFormulario);

            tobjAhorroCdt.dtmFechaFinCdt = tobjAhorroCdt.dtmFechaIniCdt.AddMonths(tobjAhorroCdt.intMesesCdt);

            tobjAhorroCdt.dtmFechaAnulado = Convert.ToDateTime("01/01/1900");

            ahorrosCdt cdt = new daoAhorrosCdt().gmtdConsultar(tobjAhorroCdt.intNumeroCdt);

            if (cdt.strNombreAho == null)
            {
                return new daoAhorrosCdt().gmtdInsertar(tobjAhorroCdt);
            }
            else
            {
                return "- Este Cdt ya aparece registrado. ";
            }
        }

        /// <summary> Consulta todos los cdt-s registrados. </summary>
        /// <returns> Un lista con todos los cdt-s seleccionados. </returns>
        public IList<ahorrosCdt> gmtdConsultarTodos()
        {
            return new daoAhorrosCdt().gmtdConsultarTodos();
        }

        /// <summary> Consulta un cdt registrado. </summary>
        /// <returns> Un cdt. </returns>
        public ahorrosCdt gmtdConsultar(int tintCdt)
        {
            return new daoAhorrosCdt().gmtdConsultar(tintCdt);
        }

        /// <summary> Consulta un determiando Cdt. </summary>
        /// <param name="tintCdt"> Codigo del cdt a consultar. </param>
        /// <returns> Un objeto del tipo tblAhorrosCdt con el cdt consultado. </returns>
        public tblAhorrosCdt gmtdConsultarCdt(int tintCdt)
        {
            return new daoAhorrosCdt().gmtdConsultarCdt(tintCdt);
        }


        /// <summary> Elimina un cdt. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosCdt. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosCdt tobjAhorrosCdt)
        {
            if (tobjAhorrosCdt.intNumeroCdt == 0)
                return "- Debe de ingresar el código del Cdt a eliminar. ";

            tobjAhorrosCdt.log = metodos.gmtdLog("Ingresa el Cdt.  " + tobjAhorrosCdt.intNumeroCdt.ToString(), tobjAhorrosCdt.strFormulario);

            tblAhorrosCdt cdt = new daoAhorrosCdt().gmtdConsultarCdt(tobjAhorrosCdt.intNumeroCdt);

            if (cdt.strCedulaAho == null)
                return "- Este Cdt no aparece registrado. ";
            else
            {
                tobjAhorrosCdt.intCodigoIng = cdt.intCodigoIng;
                return new daoAhorrosCdt().gmtdEliminar(tobjAhorrosCdt);
            }
        }
    }
}
