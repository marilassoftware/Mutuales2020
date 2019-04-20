namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blDeudas
    {
        /// <summary> Inserta una deuda. </summary>
        /// <param name="tobjDeuda"> Un objeto del tipo tblDeuda. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblDeuda tobjDeuda)
        {
            IList<Deuda> deuda = new List<Deuda>();
            deuda = new daoDeudas().gmtdConsultarTodos();  

            if(deuda.Count > 0)
                tobjDeuda.intCodDeu = deuda[deuda.Count-1].intCodDeu + 1;
            else
                tobjDeuda.intCodDeu = 1;

            if (tobjDeuda.decDebeDeu == 0)
                return "- Debe de ingresar el monto de la deuda.";

            if (tobjDeuda.strCodigoPar == "")
                return "- Debe de ingresar el código del par.";

            if (tobjDeuda.strCodSse == "")
                return "- Debe de seleccionar el servicio por el cual se genera la deuda. ";

            if (tobjDeuda.strCedula == String.Empty && tobjDeuda.bitGlobalDeu == false)
                return "- Debe de ingresar la cédula del socio.";

            if (tobjDeuda.strNombrePer == string.Empty && tobjDeuda.bitGlobalDeu == false)
                return "- Debe ingresar el número de cédula del cliente. ";

            List<tblDeuda> lstDeuda = new List<tblDeuda>();

            tobjDeuda.log = metodos.gmtdLog("Ingresa la deuda " + tobjDeuda.intCodDeu.ToString(), tobjDeuda.strFormulario);
            if (tobjDeuda.bitGlobalDeu == true)
            {
                IList<Socio> lstSocios = new blSocio().gmtdConsultarTodos();
                for(int a = 0; a < lstSocios.Count; a++)
                {
                    tblDeuda objDeudaGlobal = new tblDeuda();
                    objDeudaGlobal.bitCliente = false;
                    objDeudaGlobal.bitGlobalDeu = true;
                    objDeudaGlobal.decAbonaDeu = 0;
                    objDeudaGlobal.decDebeDeu = tobjDeuda.decDebeDeu;
                    objDeudaGlobal.intCodDeu = tobjDeuda.intCodDeu;
                    objDeudaGlobal.log = tobjDeuda.log;
                    objDeudaGlobal.strCedula = lstSocios[a].strCedulaSoc;
                    objDeudaGlobal.strCodigoPar = tobjDeuda.strCodigoPar;
                    objDeudaGlobal.strCodSse = tobjDeuda.strCodSse;
                    objDeudaGlobal.strFormulario = tobjDeuda.strFormulario;
                    objDeudaGlobal.strNombrePer = "";
                    //tobjDeuda.strCedula = lstSocios[a].strCedulaSoc;
                    lstDeuda.Add(objDeudaGlobal);
                }
            }
            else
                lstDeuda.Add(tobjDeuda);

            return new daoDeudas().gmtdInsertar(lstDeuda);
        }

        /// <summary> Consulta todos las deudas. </summary>
        /// <returns> Un lista con todos las deudas seleccionadas. </returns>
        public IList<Deuda> gmtdConsultarTodos()
        {
            return new daoDeudas().gmtdConsultarTodos();
        }

        /// <summary> Consulta una deuda. </summary>
        /// <param name="tintCodigo"> El código de la deuda que se quiere consultar. </param>
        /// <returns> La deuda consultada. </returns>
        public tblDeuda gmtdConsultar(int tintCodDeuda)
        {
            return new daoDeudas().gmtdConsultar(tintCodDeuda);
        }

        /// <summary> Consulta las deudas de un detreminado socio. </summary>
        /// <param name="tintCodigoSoc"> Codigo del socio al que se le van a consultar las deudas. </param>
        /// <returns> Listado de deudas seleciionadas. </returns>
        public List<Deuda> gmtdConsultarDeudasxSocio(string tstrCedula)
        {
            return new daoDeudas().gmtdConsultarDeudasxSocio(tstrCedula);
        }

        /// <summary> Elimina una deuda de la base de datos siempre y cuando esta no tenga abonos hechos a ella. </summary>
        /// <param name="tobjDeuda"> Un objeto del tipo tblServiciosSecundario. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblDeuda tobjDeuda)
        {
            if (tobjDeuda.intCodDeu == 0)
                return "- Debe de ingresar el código de deuda a eliminar.";

            tblDeuda deuda = new daoDeudas().gmtdConsultarDeudaconAbono(tobjDeuda.intCodDeu);

            if (deuda.intCodDeu != 0)
                return "- No se puede eliminar una deuda a la que se le han hecho abonos.";
            else
            {
                tobjDeuda.log = metodos.gmtdLog("Elimina la deuda " + tobjDeuda.strCodSse, tobjDeuda.strFormulario);
                return new daoDeudas().gmtdEliminar(tobjDeuda);
            }
        }

    }
}
