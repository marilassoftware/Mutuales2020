namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blPrimarios
    {
        /// <summary> Inserta un servicio primario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosPrimario. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblServiciosPrimario tobjServicio)
        {
            if (tobjServicio.intAñoSpr == 0)
                return "- Debe de ingresar el año al que pertenece el servicio. ";

            if (tobjServicio.intValorCuotaSpr == 0)
                return "- Debe de ingresar el valor de la cuota del servicio. ";

            if (tobjServicio.intValorSpr == 0)
                return "- Debe de ingresar el valor del servicio. ";

            if (tobjServicio.strCodigoPar.Trim() == "")
                return "- Debe de ingresar el código del par. ";

            if (tobjServicio.strCodSpr.Trim() == "")
                return "- Debe de ingresar el código del servicio. ";

            if (tobjServicio.strNombreSpr == "")
                return "- Debe de ingresar el código del servicio. ";

            tblServiciosPrimario ser = new daoPrimarios().gmtdConsultar(tobjServicio.strCodSpr);

            if (ser.strCodSpr == null)
            {
                tobjServicio.log = metodos.gmtdLog("Ingresa el servicio " + tobjServicio.strCodSpr, tobjServicio.strFormulario);
                return new daoPrimarios().gmtdInsertar(tobjServicio);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un servicio primario. </summary>
        /// <param name="tobjServicioPrimario"> Un objeto del tipo tblServiciosPrimario.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblServiciosPrimario tobjServicio)
        {
            if (tobjServicio.intAñoSpr == 0)
                return "- Debe de ingresar el año al que pertenece el servicio. ";

            if (tobjServicio.intValorCuotaSpr == 0)
                return "- Debe de ingresar el valor de la cuota del servicio. ";

            if (tobjServicio.intValorSpr == 0)
                return "- Debe de ingresar el valor del servicio. ";

            if (tobjServicio.strCodigoPar.Trim() == "")
                return "- Debe de ingresar el código del par. ";

            if (tobjServicio.strCodSpr.Trim() == "")
                return "- Debe de ingresar el código del servicio. ";

            if (tobjServicio.strNombreSpr == "")
                return "- Debe de ingresar el código del servicio. ";

            tblServiciosPrimario ser = new daoPrimarios().gmtdConsultar(tobjServicio.strCodSpr);

            if (ser.strCodSpr == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjServicio.log = metodos.gmtdLog("Modifica el servicio " + tobjServicio.strCodSpr, tobjServicio.strFormulario);
                return new daoPrimarios().gmtdEditar(tobjServicio);
            }
        }

        /// <summary> Consulta todos los servicios primarios. </summary>
        /// <returns> Un lista con todos los servicios primarios seleccionados. </returns>
        public IList<Primarios> gmtdConsultarTodos()
        {
            return new daoPrimarios().gmtdConsultarTodos();  
        }

        /// <summary> Consulta un determinado servicio primario. </summary>
        /// <param name="tstrCodigo"> El código de servicio primario a consultar. </param>
        /// <returns> Un servicio primario consultado. </returns>
        public tblServiciosPrimario gmtdConsultar(string tstrCodigo)
        {
            return new daoPrimarios().gmtdConsultar(tstrCodigo);
        }

        /// <summary> Elimina un servicio primario de la base de datos. </summary>
        /// <param name="tobjPrimarios"> Un objeto del tipo tblServiciosPrimarios. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblServiciosPrimario tobjServicio)
        {
            if (tobjServicio.strCodSpr.Trim() == "")
                return "- Debe de ingresar el código del servicio. ";

            tblServiciosPrimario ser = new daoPrimarios().gmtdConsultar(tobjServicio.strCodSpr);

            if (ser.strCodSpr == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjServicio.log = metodos.gmtdLog("Elimina el servicio " + tobjServicio.strCodSpr, tobjServicio.strFormulario);
                return new daoPrimarios().gmtdEliminar(tobjServicio);
            }
        }
    }
}
