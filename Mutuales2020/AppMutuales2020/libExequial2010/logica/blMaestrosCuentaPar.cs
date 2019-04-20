namespace libMutuales2020.logica
{
    using System.Collections.Generic;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    public class blCuentaPar
    {
        /// <summary> Inserta un Par. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par.  </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCuentasPare tobjCuentaPar)
        {
            if (tobjCuentaPar.strCodigoPar == "")
                return "- Debe de ingresar el código de la cuenta.";

            if (tobjCuentaPar.lstDebito == null)
                return "- Debe de ingresar las cuentas debito.";

            if (tobjCuentaPar.lstCredito == null)
                return "- Debe de ingresar las cuentas crésditos.";

            if(tobjCuentaPar.strDescripcion == null || tobjCuentaPar.strDescripcion.Trim() == "")
                return "- Debe de ingresar la descripción de la cuenta.";

            double dblCreditos = 0;
            for (int a = 0; a < tobjCuentaPar.lstCredito.Count; a++)
            {
                dblCreditos += tobjCuentaPar.lstCredito[a].fltPorcentaje;  
            }

            if (dblCreditos != 100)
                return "- la suma de los porcentajes de las cuentas credito debe ser igual a 100";

            for (int a = 0; a < tobjCuentaPar.lstCredito.Count - 1; a++)
            {
                int intInicia = a + 1;
                for (int b = intInicia; b < tobjCuentaPar.lstCredito.Count; b++)
                {
                    if (tobjCuentaPar.lstCredito[a].strCuenta == tobjCuentaPar.lstCredito[b].strCuenta)
                    { 
                        return "- No puede haber 2 cuentas credito iguales. ";
                    }
                }
            }

            double dblDebitos = 0;
            for (int a = 0; a < tobjCuentaPar.lstDebito.Count; a++)
            {
                dblDebitos += tobjCuentaPar.lstDebito[a].fltPorcentaje;
            }

            if (dblDebitos != 100)
                return "- la suma de los porcentajes de las cuentas debito debe ser igual a 100";

            for (int a = 0; a < tobjCuentaPar.lstDebito.Count - 1; a++)
            {
                for (int b = a + 1; b < tobjCuentaPar.lstDebito.Count; b++)
                {
                    if (tobjCuentaPar.lstDebito[a].strCuenta == tobjCuentaPar.lstDebito[b].strCuenta)
                    {
                        return "- No puede haber 2 cuentas debito iguales. ";
                    }
                }
            }

            List<cuentaPar> cue = new daoPar().gmtdConsultar(tobjCuentaPar.strCodigoPar);

            if (cue.Count > 0)
                return "- Este registro ya aparece ingresado.";
            else
            {
                tobjCuentaPar.log = metodos.gmtdLog("Ingresa el par " + tobjCuentaPar.strCodigoPar, tobjCuentaPar.strFormulario);
                return new daoPar().gmtdInsertar(tobjCuentaPar);
            }
        }

        /// <summary> Modifica un par. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCuentasPare tobjCuentaPar)
        {
            if (tobjCuentaPar.strCodigoPar == "")
            {
                return "- Debe de ingresar el código de la cuenta.";
            }

            if (tobjCuentaPar.lstDebito == null)
            {
                return "- Debe de ingresar la descripción de la cuenta.";
            }

            if (tobjCuentaPar.lstCredito == null)
            {
                return "- Debe de ingresar la descripción de la cuenta.";
            }

            List<cuentaPar> cue = new daoPar().gmtdConsultar(tobjCuentaPar.strCodigoPar);

            if (cue.Count > 0)
            {
                tobjCuentaPar.log = metodos.gmtdLog("Edita el par " + tobjCuentaPar.strCodigoPar, tobjCuentaPar.strFormulario);
                return new daoPar().gmtdEditar(tobjCuentaPar);
            }
            else
                return "- Este registro no aparece ingresado.";
        }

        /// <summary> Consulta los pares registrados. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas los pares seleccionados. </returns>
        public List<cuentaPar> gmtdConsultarTodos()
        {
            return new daoPar().gmtdConsultarTodos();
        }

        /// <summary> Elimina un par de la base de datos. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par que se va a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public string gmtdEliminar(tblCuentasPare tobjCuentaPar)
        {
            if (tobjCuentaPar.strCodigoPar == "")
                return "- Debe de ingresar el código de la cuenta.";

            List<cuentaPar> cue = new daoPar().gmtdConsultar(tobjCuentaPar.strCodigoPar);

            if (cue.Count > 0)
            {
                if(!cue[0].bitEliminar)
                    return "- Este par no se puede eliminar.";

                tobjCuentaPar.log = metodos.gmtdLog("Elimina el par " + tobjCuentaPar.strCodigoPar, tobjCuentaPar.strFormulario);
                return new daoPar().gmtdEliminar(tobjCuentaPar);
            }
            else
                return "- Este registro no aparece ingresado.";
        }

        /// <summary> Consulta los cuentas credito registradas a un determinado par. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public List<cuentaCredito> gmtdConsultarCreditos(string tstrCodigoPar)
        {
            return new daoPar().gmtdConsultarCreditos(tstrCodigoPar);
        }

        /// <summary> Consulta los cuentas debito registradas a un determinado par. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public List<cuentaDebito> gmtdConsultarDebitos(string tstrCodigoPar)
        {
            return new daoPar().gmtdConsultarDebitos(tstrCodigoPar);
        }

        /// <summary> Genera un vector de 2 posiciones, la primera posición almacena los creditos y la segunta los debitos </summary>
        /// <param name="tstrCodigoPar"> Código del par. </param>
        /// <param name="tdecValor"> Código del valor. </param>
        /// <returns> Un vector con las 2 posiciones indicadas. </returns>
        public List<cuentaValores>[] gmtdCalcularValores(string tstrCodigoPar, decimal tdecValor)
        {
            decimal decValorCuenta = 0;
            decimal decValorExedente = 0;


            List<cuentaCredito> lstCuentasCredito = this.gmtdConsultarCreditos(tstrCodigoPar);
            List<cuentaValores> lstCuentaValoresCreditos = new List<cuentaValores>();
            decValorExedente = tdecValor;
            for (int a = 0; a < lstCuentasCredito.Count -1; a++)
            {
                cuentaValores cuentaValor = new cuentaValores();
                cuentaValor.strCuenta = lstCuentasCredito[a].strCuenta;
                decValorCuenta = tdecValor * (lstCuentasCredito[a].decPorcentaje / 100);
                cuentaValor.decValor = decValorCuenta;
                decValorExedente -= decValorCuenta;

                lstCuentaValoresCreditos.Add(cuentaValor);
            }
            cuentaValores cuentaValorUltima = new cuentaValores();
            cuentaValorUltima.strCuenta = lstCuentasCredito[lstCuentasCredito.Count - 1].strCuenta;
            cuentaValorUltima.decValor = decValorExedente;
            lstCuentaValoresCreditos.Add(cuentaValorUltima);

            List<cuentaDebito> lstCuentasDebito = this.gmtdConsultarDebitos(tstrCodigoPar);
            List<cuentaValores> lstCuentaValoresDebitos = new List<cuentaValores>();
            decValorExedente = tdecValor;
            for (int a = 0; a < lstCuentasDebito.Count - 1; a++)
            {
                cuentaValores cuentaValor = new cuentaValores();
                cuentaValor.strCuenta = lstCuentasDebito[a].strCuenta;
                decValorCuenta = tdecValor * (lstCuentasDebito[a].decPorcentaje / 100);
                cuentaValor.decValor = decValorCuenta;
                decValorExedente -= decValorCuenta;
                lstCuentaValoresDebitos.Add(cuentaValor);
            }
            cuentaValorUltima = new cuentaValores();
            cuentaValorUltima.strCuenta = lstCuentasDebito[lstCuentasDebito.Count - 1].strCuenta;
            cuentaValorUltima.decValor = decValorExedente;
            lstCuentaValoresDebitos.Add(cuentaValorUltima);

            List<cuentaValores>[] lstLista = new List<cuentaValores>[2]{lstCuentaValoresCreditos, lstCuentaValoresDebitos};
            return lstLista;
        }
    }
}
