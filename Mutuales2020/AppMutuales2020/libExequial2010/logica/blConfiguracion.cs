using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dao;
using libMutuales2020.dominio;
using System.ComponentModel;
using Conversiones;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blConfiguracion
    {
        /// <summary> Consulta los datos de configuración del sistema. </summary>
        /// <returns> Los datos de configuración consultados. </returns>
        public tblConfiguracione gmtdConsultaConfiguracion()
        {
            return new daoUtilidadesConfiguracion().gmtdConsultaConfiguracion();
        }

        /// <summary> Actualiza los datos de la tabla de configuraciones. </summary>
        /// <param name="tobjConfiguracion"> Objeto con los datos a actualizar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdActualizarDatosdeConfiguracion(tblConfiguracione tobjConfiguracion)
        {
            return new daoUtilidadesConfiguracion().gmtdActualizarDatosdeConfiguracion(tobjConfiguracion);
        }

        /// <summary> Consulta el valor de la fecha actual. </summary>
        /// <returns> La fecha actual del servidor de base de datos. </returns>
        public DateTime gmtdCapturarFechadelServidor()
        {
            return new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();
        }

        /// <summary> Realiza el respaldo de la base de datos. </summary>
        /// <param name="tstrCadena"> Cadena de conexion a la base de datos. </param>
        /// <returns> Un mensaje que indica si se pudo o no ejecutar el respaldo. </returns>
        public string gmtdRespaldarBasedeDatos(string tstrCadena)
        {
            return new daoUtilidadesConfiguracion().gmtdRespaldarBasedeDatos(tstrCadena);
        }

        /// <summary> Consulta todos los videos registrados. </summary>
        /// <returns> Un lista con todos los videos seleccionados. </returns>
        public List<tblVideosAyuda> gmtdConsultarTodoslosVideos()
        {
            return new daoUtilidadesConfiguracion().gmtdConsultarTodoslosVideos();
        }

        /// <summary> Ejecuta un sp que deshabilita los socio (Recesa) </summary>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdDeshabilitarSocios()
        {
            return new daoUtilidadesConfiguracion().gmtdDeshabilitarSocios();
        }

        /// <summary> Insert el número de rifa para un socio o código de préstamo. </summary>
        /// <param name="tobjRifa"> Un objeto con los datos a ingresar de un número de rifa.</param>
        /// <param name="tstrTipo"> Un código que indica si se va a insertar un código de rifa para un socio (02) o para un crédito(04)</param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdInsertarNumeroRifa(tblNumerosRifa tobjRifa, string tstrTipo)
        {
            return new daoUtilidadesConfiguracion().gmtdInsertarNumeroRifa(tobjRifa, tstrTipo);
        }

        /// <summary> Consulta los códigos de socio o préstamos disponibles para asignarles número de rifa. </summary>
        /// <param name="tobjRifa"> Un objeto del tipo tblRifa </param>
        /// <param name="tstrTipo"> Un valor que indica si se quieres consultar los socio(03) o los préstamos (05). </param>
        /// <returns></returns>
        public List<string> gmtdConsultarSociosPrestamosparaRifa(tblNumerosRifa tobjRifa, string tstrTipo)
        {
            return new daoUtilidadesConfiguracion().gmtdConsultarSociosPrestamosparaRifa(tobjRifa, tstrTipo);
        }

        /// <summary> Consulta todos los periodos registrados. </summary>
        /// <returns> La lista de periodos seleccionados. </returns>
        public List<tblCuentasPeriodo> gmtdConsultarPeriodos()
        {
            return new daoUtilidadesConfiguracion().gmtdConsultarPeriodos();
        }

        /// <summary> Pasa de un un número a su valor en letras. </summary>
        /// <param name="tstrMonto"> Valor del monto. </param>
        /// <returns> un string con la cantidad en letras. </returns>
        public string montoenLetras(string tstrMonto)
        {
            return new Conversiones.enLetras().montoenLetras(tstrMonto);
        }

        /// <summary> Consulta las quincenas registradas en un determinado año.</summary>
        /// <param name="tintAño"> El año del que se quieren seleccionar las quincenas.</param>
        /// <returns> Listado de quincenas consultadas.</returns>
        public List<tblQuincena> gmtdConsultarQuincenas(int tintAño)
        {
            return new daoUtilidadesConfiguracion().gmtdConsultarQuincenas(tintAño);
        }
    }
}
