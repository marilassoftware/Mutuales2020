using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoAgraciado
    {
        /// <summary> Inserta un Agraciado. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo agraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAgraciado tobjAgraciado)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext agraciado = new dbExequial2010DataContext())
                {
                    agraciado.tblAgraciados.InsertOnSubmit(tobjAgraciado);
                    //Actualiza el número de agraciados para un socio en la tabla de socios.
                    tblSocio soc_old = agraciado.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjAgraciado.intCodigoSoc);
                    soc_old.intAgraciados += 1;
                    agraciado.tblLogdeActividades.InsertOnSubmit(tobjAgraciado.log);
                    agraciado.SubmitChanges();
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

        /// <summary> Inserta un Agraciado desde la pantalla de modificación de cédulas. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo agraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertarxModificaciondeCedula(tblAgraciado tobjAgraciado)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext agraciado = new dbExequial2010DataContext())
                {
                    agraciado.tblAgraciados.InsertOnSubmit(tobjAgraciado);
                    agraciado.SubmitChanges();
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

        /// <summary> Modifica un Agraciado. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo Agraciado.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblAgraciado tobjAgraciado)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext agraciado = new dbExequial2010DataContext())
                {
                    tblAgraciado agra_old = agraciado.tblAgraciados.SingleOrDefault(p => p.strCedulaAgra == tobjAgraciado.strCedulaAgra);
                    agra_old.bitSexo = tobjAgraciado.bitSexo;
                    agra_old.dtmFechaIng = tobjAgraciado.dtmFechaIng;
                    agra_old.dtmFechaNac = tobjAgraciado.dtmFechaNac;
                    agra_old.strApellido1Agra = tobjAgraciado.strApellido1Agra;
                    agra_old.strApellido2Agra = tobjAgraciado.strApellido2Agra;
                    agra_old.strCodBarrio = tobjAgraciado.strCodBarrio;
                    agra_old.strCodOficio = tobjAgraciado.strCodOficio;
                    agra_old.strCorreo = tobjAgraciado.strCorreo;
                    agra_old.strDireccion = tobjAgraciado.strDireccion;
                    agra_old.strEscolaridad = tobjAgraciado.strEscolaridad;
                    agra_old.strNombreAgra = tobjAgraciado.strNombreAgra;
                    agra_old.strTelefono = tobjAgraciado.strTelefono;
                    agra_old.strTipoCed = tobjAgraciado.strTipoCed;
                    agra_old.strParentesco = tobjAgraciado.strParentesco;
                    agra_old.strLugarExpedicion = tobjAgraciado.strLugarExpedicion;
                    agra_old.dtmFechaExpedicion = tobjAgraciado.dtmFechaExpedicion;
                    agraciado.tblLogdeActividades.InsertOnSubmit(tobjAgraciado.log);
                    agraciado.SubmitChanges();
                    strResultado = "Registro Actualizado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }
            return strResultado;
        }

        /// <summary> Modifica los datos del agraciado solicitados por la aseguradora. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo persona a modificar.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdActualizarDato(personasaModificar tobjPersona)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext socio = new dbExequial2010DataContext())
                {
                    tblAgraciado agr_old = socio.tblAgraciados.SingleOrDefault(p => p.strCedulaAgra == tobjPersona.strCedula);
                    agr_old.dtmFechaNac = tobjPersona.dtmFechaNacimeinto;
                    agr_old.strApellido1Agra = tobjPersona.strApellido1;
                    agr_old.strApellido2Agra = tobjPersona.strApellido2;
                    agr_old.strCedulaAgra = tobjPersona.strCedula;
                    agr_old.strDireccion = tobjPersona.strDireccion;
                    agr_old.strNombreAgra = tobjPersona.strNombre;
                    agr_old.strTelefono = tobjPersona.strTelefono;
                    agr_old.bitActualizado = true;
                    socio.tblLogdeActividades.InsertOnSubmit(tobjPersona.log);
                    socio.SubmitChanges();
                    strResultado = "Registro Actualizado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }
            return strResultado;
        }

        /// <summary> Modifica un la cédula de un agraciado. </summary>
        /// <param name="tobjAgraciado"> Número de cédula que desea modificar. </param>
        /// <param name="tobjAgraciado"> Número de cédula a modificar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditarCeduladeAgraciado(string tstrCedulaaModificar, string tstrCambiarpor)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext agraciado = new dbExequial2010DataContext())
                {
                    tblAgraciado agra_old = agraciado.tblAgraciados.SingleOrDefault(p => p.strCedulaAgra == tstrCedulaaModificar);
                    agra_old.strCedulaAgra = tstrCambiarpor;
                    agraciado.SubmitChanges();
                    strResultado = "Registro Actualizado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }
            return strResultado;
        }

        /// <summary> Consulta los datos de un determinado agraciado a partir de la cédula. </summary>
        /// <param name="tintSocio"> El código del agracaiado a consultar </param>
        /// <returns> Los datos de agraciado consultado. </returns>
        public tblAgraciado gmtdConsultarDetalle(string tstrCedulaAgra)
        {
            using (dbExequial2010DataContext agraciados = new dbExequial2010DataContext())
            {
                var query = from agr in agraciados.tblAgraciados
                            join ofi in agraciados.tblOficios on agr.strCodOficio equals ofi.strCodOficio
                            join bar in agraciados.tblBarrios on agr.strCodBarrio equals bar.strCodBarrio
                            where agr.bitAnulado == false && agr.strCedulaAgra == tstrCedulaAgra
                            select new { soc = agr };


                tblAgraciado agraciado = new tblAgraciado();
                foreach (var dato in query.ToList())
                {
                    agraciado.bitSexo = dato.soc.bitSexo;
                    agraciado.dtmFechaIng = dato.soc.dtmFechaIng;
                    agraciado.dtmFechaNac = dato.soc.dtmFechaNac;
                    agraciado.intCodigoSoc = dato.soc.intCodigoSoc;
                    agraciado.strApellido1Agra = dato.soc.strApellido1Agra;
                    agraciado.strApellido2Agra = dato.soc.strApellido2Agra;
                    agraciado.strCedulaAgra = dato.soc.strCedulaAgra;
                    agraciado.strCodBarrio = dato.soc.strCodBarrio;
                    agraciado.strCodOficio = dato.soc.strCodOficio;
                    agraciado.strCorreo = dato.soc.strCorreo;
                    agraciado.strDireccion = dato.soc.strDireccion;
                    agraciado.strEscolaridad = dato.soc.strEscolaridad;
                    agraciado.strNombreAgra = dato.soc.strNombreAgra;
                    agraciado.strTelefono = dato.soc.strTelefono;
                    agraciado.strTipoCed = dato.soc.strTipoCed;
                    agraciado.strParentesco = dato.soc.strParentesco;
                    agraciado.dtmFechaExpedicion = dato.soc.dtmFechaExpedicion;
                    agraciado.strLugarExpedicion = dato.soc.strLugarExpedicion;
                }
                return agraciado;

            }
        }

        /// <summary> Consulta los agraciados registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los agraciados. </param>
        /// <returns> Lista de los agraciados consultados. </returns>
        public List<tblAgraciado> gmtdConsultarAgraciadosxBarrio(string tstrCodigoBar)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from soc in personas.tblAgraciados
                            where soc.strCodBarrio == tstrCodigoBar && soc.bitAnulado == false
                            select soc;

                if (query.ToList().Count > 0)
                    return query.ToList();
                else
                    return new List<tblAgraciado>();
            }
        }

        /// <summary> Consulta todos los agraciados registrados. </summary>
        /// <returns> Un lista con todos los socios seleccionados. </returns>
        public IList<Agraciado> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext agraciados = new dbExequial2010DataContext())
            {
                var query = from agr in agraciados.tblAgraciados
                            where agr.bitAnulado == false
                            orderby agr.strCedulaAgra ascending
                            select agr;
                List<Agraciado> lstAgraciado = new List<Agraciado>();

                foreach (var dato in query.ToList())
                {
                    Agraciado Agra = new Agraciado();
                    Agra.intCodigoSoc = dato.intCodigoSoc;
                    Agra.strApellidoAgra = dato.strApellido1Agra + " " + dato.strApellido2Agra;
                    Agra.strCedulaAgra = dato.strCedulaAgra;
                    Agra.strDireccion = dato.strDireccion;
                    Agra.strNombreAgra = dato.strNombreAgra;
                    Agra.strTelefono = dato.strTelefono;
                    Agra.strParentesco = dato.strParentesco;
                    lstAgraciado.Add(Agra);
                }
                return lstAgraciado;
            }
        }

        /// <summary> Consulta un determinado agraciado. </summary>
        /// <param name="tstrCedAgraciado">la cédula del agraciado a consultar.</param>
        /// <returns> un objeto del tipo tblAgraciado. </returns>
        public tblAgraciado gmtdConsultar(string tstrCedAgraciado)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from agra in personas.tblAgraciados
                            where agra.strCedulaAgra == tstrCedAgraciado && agra.bitAnulado == false
                            select agra;

                if (query.ToList().Count > 0)
                {
                    return query.ToList()[0];
                }
                else
                {
                    return new tblAgraciado(); 
                }
            }
        }

        public tblAgraciado gmtdConsultarAnulado(string tstrCedAgraciado)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from agra in personas.tblAgraciados
                            where agra.strCedulaAgra == tstrCedAgraciado && agra.bitAnulado == true
                            select agra;

                if (query.ToList().Count > 0)
                {
                    return query.ToList()[0];
                }
                else
                {
                    return new tblAgraciado();
                }
            }
        }

        /// <summary> Elimina un agraciado de la base de datos. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo tblAgraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAgraciado tobjAgraciado)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
                {
                    tblAgraciado agra_old = personas.tblAgraciados.SingleOrDefault(p => p.intCodigoAgr == tobjAgraciado.intCodigoAgr);
                    agra_old.bitAnulado = true;
                    agra_old.dtmFecAnulado = DateTime.Now;   
                    personas.tblLogdeActividades.InsertOnSubmit(tobjAgraciado.log);
                    tblSocio soc_old = personas.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjAgraciado.intCodigoSoc);
                    soc_old.intAgraciados -= 1;
                    personas.SubmitChanges();
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

        /// <summary> Elimina fisicamente un agraciado de la base de datos, este metodo solo se utiliza en la pantalla de cambio de cédula al agraciado, que se elimina para poderlo registrar con la nueva cédula. </summary>
        /// <param name="tobjAgraciado"> Un objeto con los datos del agraciado. </param>
        /// <returns></returns>
        public bool gmtdEliminarFisicamenteunAgraciado(tblAgraciado tobjAgraciado)
        {
            bool bitResultado;
            try
            {
                using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
                {
                    var query = from agra in personas.tblAgraciados
                                where agra.strCedulaAgra == tobjAgraciado.strCedulaAgra
                                select agra;

                    foreach (var detail in query)
                    {
                        personas.tblAgraciados.DeleteOnSubmit(detail);
                    }
                    personas.SubmitChanges();
                    bitResultado = true;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                bitResultado = false;
            }
            return bitResultado;
        }

        /// <summary>Selecciona los agraciados registrados cuya informacíón coincida con los campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Agraciado> gmtdFiltrar(tblAgraciado tobjAgraciados)
        {
            using (dbExequial2010DataContext agraciados = new dbExequial2010DataContext())
            {
                var query = from agra in agraciados.tblAgraciados
                            where agra.bitAnulado == false
                            && agra.strCedulaAgra.ToUpper().StartsWith(tobjAgraciados.strCedulaAgra.ToUpper())
                            && agra.strNombreAgra.ToUpper().StartsWith(tobjAgraciados.strNombreAgra.ToUpper())
                            && agra.strApellido1Agra.ToUpper().StartsWith(tobjAgraciados.strApellido1Agra.ToUpper())
                            && agra.strApellido2Agra.ToUpper().StartsWith(tobjAgraciados.strApellido2Agra.ToUpper())
                            select agra;

                List<Agraciado> lstAgraciado = new List<Agraciado>();
                foreach (var dato in query.ToList())
                {
                    Agraciado agra = new Agraciado();
                    agra.intCodigoSoc = dato.intCodigoSoc;
                    agra.strApellidoAgra = dato.strApellido1Agra + " " + dato.strApellido2Agra;
                    agra.strCedulaAgra = dato.strCedulaAgra;
                    agra.strDireccion = dato.strDireccion;
                    agra.strNombreAgra = dato.strNombreAgra;
                    agra.strTelefono = dato.strTelefono;
                    agra.strParentesco = dato.strParentesco;
                    lstAgraciado.Add(agra);
                }
                return lstAgraciado;
            }
        }

        /// <summary> Consulta los agraciados registrados a un determinado socio. </summary>
        /// <param name="tintCodigoSocio"> Código del socio a consultar. </param>
        /// <returns> El listado de los agraciados seleccionados. </returns>
        public List<Agraciado> gmtdConsultar(int tintCodigoSocio)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from agra in personas.tblAgraciados
                            where agra.intCodigoSoc == tintCodigoSocio && agra.bitAnulado == false
                            select agra;

                List<Agraciado> agraciado = new List<Agraciado>();
                foreach (var dato in query.ToList())
                {
                    Agraciado Agra = new Agraciado();
                    Agra.intCodigoSoc = dato.intCodigoSoc;
                    Agra.strApellidoAgra = dato.strApellido1Agra + " " + dato.strApellido2Agra;
                    Agra.strCedulaAgra = dato.strCedulaAgra;
                    Agra.strDireccion = dato.strDireccion;
                    Agra.strNombreAgra = dato.strNombreAgra;
                    Agra.strTelefono = dato.strTelefono;
                    Agra.strParentesco = dato.strParentesco;
                    Agra.strNombreCompleto = dato.strNombreAgra + " " + dato.strApellido1Agra + " " + dato.strApellido2Agra;
                    Agra.bitActualizado = (bool)dato.bitActualizado;
                    Agra.dtmFechaNac = dato.dtmFechaNac;
                    Agra.strApellido1 = dato.strApellido1Agra;
                    Agra.strApellido2 = dato.strApellido2Agra;
                    agraciado.Add(Agra);
                }

                return agraciado;
            }
        }

        /// <summary> Habilita un agraciado que se encuentre deshabilitado. </summary>
        /// <param name="tstrCedulaAgra"> Cédula del agraciado a habilitar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdHabilitarAnulado(string tstrCedulaAgra)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
                {
                    tblAgraciado agra_old = personas.tblAgraciados.SingleOrDefault(p => p.strCedulaAgra == tstrCedulaAgra);
                    agra_old.bitAnulado = false;
                    agra_old.dtmFecAnulado = Convert.ToDateTime("1/1/1900");

                    tblSocio soc_old = personas.tblSocios.SingleOrDefault(p => p.intCodigoSoc == agra_old.intCodigoSoc);
                    soc_old.intAgraciados ++;

                    personas.SubmitChanges();

                    strResultado = "Registro Actualizado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }
            return strResultado;
        }

    }
}
