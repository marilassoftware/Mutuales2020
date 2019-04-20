using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoDeudas
    {
        /// <summary> Inserta una deuda. </summary>
        /// <param name="tobjDeuda"> Una lista de objetos del tipo tblDeuda. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(List<tblDeuda> tobjDeuda)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext deudaa = new dbExequial2010DataContext())
                {
                    for(int a = 0; a < tobjDeuda.Count ; a++)
                    {
                        deudaa.tblDeudas.InsertOnSubmit(tobjDeuda[a]);
                    }
                    deudaa.tblLogdeActividades.InsertOnSubmit(tobjDeuda[0].log);
                    deudaa.SubmitChanges();
                    strRetornar = "Registro Insertado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strRetornar = "- Ocurrió un error al insertar el registro.";
            }
            return strRetornar;
        }

        /// <summary> Consulta todos las deudas. </summary>
        /// <returns> Un lista con todos las deudas seleccionadas. </returns>
        public IList<Deuda> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext deudas = new dbExequial2010DataContext())
            {
                var query = from deu in deudas.tblDeudas
                            select deu;

                List<Deuda> lstDeudas = new List<Deuda>();

                foreach (var dato in query.ToList())
                {
                    Deuda deusec = new Deuda();
                    deusec.bitGlobalDeu = dato.bitGlobalDeu;
                    deusec.decAbonaDeu = dato.decAbonaDeu;
                    deusec.intCodDeu = dato.intCodDeu;
                    deusec.strCedula = dato.strCedula;
                    deusec.decDebeDeu = dato.decDebeDeu;
                    deusec.strCodigoPar = dato.strCodigoPar;
                    deusec.strCodSse = dato.strCodSse;
                    lstDeudas.Add(deusec);
                }

                return lstDeudas;
            }
        }

        /// <summary> Consulta una deuda. </summary>
        /// <param name="tintCodigo"> El código de la deuda que se quiere consultar. </param>
        /// <returns> La deuda consultada. </returns>
        public tblDeuda gmtdConsultar(int tintCodDeuda)
        {
            using (dbExequial2010DataContext deudas = new dbExequial2010DataContext())
            {
                var query = from deu in deudas.tblDeudas
                            where deu.intCodDeu == tintCodDeuda
                            select deu;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblDeuda();

            }
        }

        /// <summary> Consulta una deuda siempre y cuando tenga algo abonado. </summary>
        /// <param name="tintCodigo"> El código de la deuda que se quiere consultar. </param>
        /// <returns> La deuda consultada. </returns>
        public tblDeuda gmtdConsultarDeudaconAbono(int tintCodDeuda)
        {
            using (dbExequial2010DataContext deudas = new dbExequial2010DataContext())
            {
                var query = from deu in deudas.tblDeudas
                            where deu.intCodDeu == tintCodDeuda && deu.decAbonaDeu > 0
                            select deu;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblDeuda();

            }
        }

        /// <summary> Consulta las deudas de una detreminada persona. </summary>
        /// <param name="tstrCedula"> Cèdula de la persona a la que se le va a consultar las cedulas. </param>
        /// <returns> Listado de deudas seleciionadas. </returns>
        public List<Deuda> gmtdConsultarDeudasxSocio(string tstrCedula)
        {
            using (dbExequial2010DataContext deudas = new dbExequial2010DataContext())
            {
                var query = from deu in deudas.tblDeudas
                            join ser in deudas.tblServiciosSecundarios on deu.strCodSse equals ser.strCodSse
                            where deu.strCedula == tstrCedula && deu.decDebeDeu > 0
                            select new { deu.intCodDeu, deu.decDebeDeu, ser.strNombreSse };
                List<Deuda> lstDeudas = new List<Deuda>();

                foreach(var dato in query.ToList())
                {
                    Deuda deuda = new Deuda();
                    deuda.decDebeDeu = dato.decDebeDeu;
                    deuda.intCodDeu = dato.intCodDeu;
                    deuda.strNombreDeuda = dato.strNombreSse;
                    lstDeudas.Add(deuda);
                }

                return lstDeudas;
            }
        }

        /// <summary> Elimina una deuda de la base de datos. </summary>
        /// <param name="tobjDeuda"> Un objeto del tipo tblDeuda. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblDeuda tobjDeuda)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext deudas = new dbExequial2010DataContext())
                {
                    var query = from deu in deudas.tblDeudas
                                where deu.intCodDeu == tobjDeuda.intCodDeu
                                select deu;

                    foreach (var detail in query)
                    {
                        deudas.tblDeudas.DeleteOnSubmit(detail);
                    }

                    deudas.tblLogdeActividades.InsertOnSubmit(tobjDeuda.log);
                    deudas.SubmitChanges();
                    strResultado = "Registro Eliminado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- No se puede eliminar el registro.";
            }
            return strResultado;
        }
    }
}
