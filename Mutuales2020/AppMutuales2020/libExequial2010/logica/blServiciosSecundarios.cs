namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blSecundarios
    {
        /// <summary> Inserta un servicio secundario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblServiciosSecundario tobjServicio)
        {
            if (tobjServicio.strCodSse.Trim() == "")
                return "- Debe ingresar el código del servicio. ";

            if (tobjServicio.strNombreSse == "")
                return "- Debe ingresar el nombre del servicio. ";

            if (tobjServicio.strCodigoPar == "")
                return "- Debe ingresar el código del par. ";

            if (tobjServicio.intValorSse == 0)
                return "- Debe ingresar el valor del servicio. ";

            tblServiciosSecundario ser = new daoSecundarios().gmtdConsultar(tobjServicio.strCodSse);

            if (ser.strCodSse == null)
            {
                tobjServicio.log = metodos.gmtdLog("Ingresa el servicio secundario " + tobjServicio.strCodSse, tobjServicio.strFormulario);
                return new daoSecundarios().gmtdInsertar(tobjServicio);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un servicio secundario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblServiciosSecundario tobjServicio)
        {
            if (tobjServicio.strCodSse.Trim() == "")
                return "- Debe ingresar el código del servicio. ";

            if (tobjServicio.strNombreSse == "")
                return "- Debe ingresar el nombre del servicio. ";

            if (tobjServicio.strCodigoPar == "")
                return "- Debe ingresar el código del par. ";

            if (tobjServicio.intValorSse == 0)
                return "- Debe ingresar el valor del servicio. ";

            tblServiciosSecundario ser = new daoSecundarios().gmtdConsultar(tobjServicio.strCodSse);

            if (ser.strCodSse == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjServicio.log = metodos.gmtdLog("Modifica el servicio secundario " + tobjServicio.strCodSse, tobjServicio.strFormulario);
                return new daoSecundarios().gmtdEditar(tobjServicio);
            }
        }

        /// <summary> Consulta todos los servicios secundarios. </summary>
        /// <returns> Un lista con todos los servicios secundarios seleccionados. </returns>
        public IList<Secundarios> gmtdConsultarTodos()
        {
            return new daoSecundarios().gmtdConsultarTodos();   
        }

        /// <summary> Consulta un determinado servicio secundario. </summary>
        /// <param name="tstrCodigo"> El código de servicio secundario a consultar. </param>
        /// <returns> Un servicio secundario consultado. </returns>
        public tblServiciosSecundario gmtdConsultar(string tstrCodigo)
        {
            return new daoSecundarios().gmtdConsultar(tstrCodigo);
        }

        /// <summary> Elimina un servicio secundario de la base de datos. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblServiciosSecundario tobjServicio)
        {
            if (tobjServicio.strCodSse.Trim() == "")
                return "- Debe ingresar el código del servicio. ";

            tblServiciosSecundario ser = new daoSecundarios().gmtdConsultar(tobjServicio.strCodSse);

            if (ser.strCodSse == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjServicio.log = metodos.gmtdLog("Elimino el servicio secundario " + tobjServicio.strCodSse, tobjServicio.strFormulario);
                return new daoSecundarios().gmtdEliminar(tobjServicio);
            }
        }
    }
}
