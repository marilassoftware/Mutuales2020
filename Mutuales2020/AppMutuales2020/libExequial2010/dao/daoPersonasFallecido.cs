using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoFallecido
    {
        /// <summary> Inserta un fallecido. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo agraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblFallecido tobjFallecido)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext persona = new dbExequial2010DataContext())
                {
                    persona.tblFallecidos.InsertOnSubmit(tobjFallecido);
                    persona.tblLogdeActividades.InsertOnSubmit(tobjFallecido.log);

                    switch (tobjFallecido.strProcedencia)
                    {
                        case "Agraciado":
                            tblAgraciado agra_old = persona.tblAgraciados.SingleOrDefault(p => p.strCedulaAgra == tobjFallecido.strCedulaFal && p.bitAnulado == false);
                            agra_old.bitAnulado = true;
                            agra_old.dtmFecAnulado = DateTime.Now;
                            tblSocio socio1 = persona.tblSocios.SingleOrDefault(p => p.intCodigoSoc == agra_old.intCodigoSoc);
                            socio1.intAgraciados--;
                            break;
                        case "Socio":
                            if (tobjFallecido.agraciado.strCedulaAgra != null)
                            {
                                tblAgraciado agra = persona.tblAgraciados.SingleOrDefault(p => p.strCedulaAgra == tobjFallecido.agraciado.strCedulaAgra && p.bitAnulado == false);
                                agra.bitAnulado = true;
                                agra.dtmFecAnulado = DateTime.Now;

                                tblSocio socio = persona.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjFallecido.intCodigoSoc);
                                socio.strTipoCed = tobjFallecido.agraciado.strTipoCed;
                                socio.strCedulaSoc = tobjFallecido.agraciado.strCedulaAgra;
                                socio.strNombreSoc = tobjFallecido.agraciado.strNombreAgra;
                                socio.strApellido1Soc = tobjFallecido.agraciado.strApellido1Agra;
                                socio.strApellido2Soc = tobjFallecido.agraciado.strApellido2Agra;
                                socio.strDireccion = tobjFallecido.agraciado.strDireccion;
                                socio.strTelefono = tobjFallecido.agraciado.strTelefono;
                                socio.bitSexo = tobjFallecido.agraciado.bitSexo;
                                socio.dtmFechaIng = tobjFallecido.agraciado.dtmFechaIng;
                                socio.dtmFechaIng = tobjFallecido.agraciado.dtmFechaNac;
                                socio.strCorreo = tobjFallecido.agraciado.strCorreo;
                                socio.strEscolaridad = tobjFallecido.agraciado.strEscolaridad;
                                socio.intAgraciados--;
                            }
                            else
                            {
                                tblSocio socio = persona.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjFallecido.intCodigoSoc && p.bitAnulado == false);
                                socio.bitAnulado = true;
                                socio.dtmFecAnulado = DateTime.Now;
                            }
                            break;
                    }
                    persona.SubmitChanges();
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

        /// <summary> Modifica un Fallecido. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo Fallecido.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblFallecido tobjFallecido)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext persona = new dbExequial2010DataContext())
                {
                    tblFallecido fall_old = persona.tblFallecidos.SingleOrDefault(p => p.strCedulaFal == tobjFallecido.strCedulaFal);
                    fall_old.bitHecho = tobjFallecido.bitHecho;
                    fall_old.dtmFechaFal = tobjFallecido.dtmFechaFal;
                    fall_old.dtmFechaNuc = tobjFallecido.dtmFechaNuc;
                    fall_old.strApellido1Fal = tobjFallecido.strApellido1Fal;
                    fall_old.strApellido2Fal = tobjFallecido.strApellido2Fal;
                    fall_old.strComentario = tobjFallecido.strComentario;
                    fall_old.strFolio = tobjFallecido.strFolio;
                    fall_old.strNombreFal = tobjFallecido.strNombreFal;
                    fall_old.strNotaria = tobjFallecido.strNotaria;
                    fall_old.strProcedencia = tobjFallecido.strProcedencia;
                    fall_old.strTipoCed = tobjFallecido.strTipoCed;
                    fall_old.intPagado = tobjFallecido.intPagado;
                    persona.tblLogdeActividades.InsertOnSubmit(tobjFallecido.log);
                    persona.SubmitChanges();
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

        /// <summary> Consulta todos los fallecidos registrados. </summary>
        /// <returns> Un lista con todos los fallecidos seleccionados. </returns>
        public List<Fallecido> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from per in personas.tblFallecidos
                            where per.bitAnulado == false
                            select per;
                List<Fallecido> lstFallecido = new List<Fallecido>();

                foreach (var dato in query.ToList())
                {
                    Fallecido Fal = new Fallecido();
                    Fal.intCodigoSoc = dato.intCodigoSoc;
                    Fal.strApellidoFal = dato.strApellido1Fal + " " + dato.strApellido2Fal;
                    Fal.strCedulaFal = dato.strCedulaFal;
                    Fal.strFolio = dato.strFolio;
                    Fal.strNotaria = dato.strNotaria;
                    Fal.strNombreFal = dato.strNombreFal;
                    lstFallecido.Add(Fal);
                }
                return lstFallecido;
            }
        }

        /// <summary>Selecciona los socios registrados cuya informacíón coicida con los
        /// campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Fallecido> gmtdFiltrar(tblFallecido tobjFallecido)
        {
            using (dbExequial2010DataContext fallecidos = new dbExequial2010DataContext())
            {
                var query = from fal in fallecidos.tblFallecidos
                            where fal.bitAnulado == false
                            && fal.strCedulaFal.StartsWith(tobjFallecido.strCedulaFal)
                            && fal.strNombreFal.StartsWith(tobjFallecido.strNombreFal)
                            && fal.strApellido1Fal.StartsWith(tobjFallecido.strApellido1Fal)
                            && fal.strApellido2Fal.StartsWith(tobjFallecido.strApellido2Fal)
                            select fal;

                List<Fallecido> lstFallecidos = new List<Fallecido>();
                foreach (var dato in query.ToList())
                {
                    Fallecido fall = new Fallecido();
                    fall.intCodigoSoc = dato.intCodigoSoc;
                    fall.strApellido1Fal = dato.strApellido1Fal;
                    fall.strApellido2Fal = dato.strApellido2Fal;
                    fall.strApellidoFal = dato.strApellido1Fal + " " + dato.strApellido2Fal;
                    fall.strCedulaFal = dato.strCedulaFal;
                    fall.strFolio = dato.strFolio;
                    fall.strNombreFal = dato.strNombreFal;
                    fall.strNotaria = dato.strNotaria;
                    fall.intAños = dato.intAños;
                    fall.intPagado = dato.intPagado;
                    fall.strProcedencia = dato.strProcedencia;
                    fall.strComentario = dato.strComentario;
                    fall.dtmFechaFal = dato.dtmFechaFal;
                    fall.dtmFechaNuc = dato.dtmFechaNuc;
                    lstFallecidos.Add(fall);
                }
                return lstFallecidos;
            }
        }


        /// <summary> Consulta todos los fallecidos registrados. </summary>
        /// <returns> Un lista con todos los fallecidos seleccionados. </returns>
        public IList<tblFallecido> gmtdConsultarTodosTbl()
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from per in personas.tblFallecidos
                            where per.bitAnulado == false
                            select per;

                return query.ToList();
            }
        }

        /// <summary> Consulta los fallecidos registrados en un rango de fecha </summary>
        /// <param name="tdtmFechaIni"> Fecha inicial.</param>
        /// <param name="tdtmFechaFin"> Fecha Final. </param>
        /// <returns> El listado de los fallecidos seleccionados. </returns>
        public List<tblFallecido> gmtdConsultarFallecidosentreFechas(DateTime tdtmFechaIni, DateTime tdtmFechaFin)
        {
            using (dbExequial2010DataContext fallecidos = new dbExequial2010DataContext())
            {
                var query = from consu in fallecidos.tblFallecidos
                            where consu.dtmFechaFal >= tdtmFechaIni && consu.dtmFechaFal <= tdtmFechaFin
                            select consu;

                return query.ToList();
            }
        }

        /// <summary> Consulta un determinado Fallecido. </summary>
        /// <param name="tstrCedFallecido">la cédula del Fallecido a consultar.</param>
        /// <returns> un objeto del tipo tblFallecido. </returns>
        public tblFallecido gmtdConsultar(string tstrCedFallecido)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from fal in personas.tblFallecidos
                            where fal.strCedulaFal == tstrCedFallecido && fal.bitAnulado == false
                            select fal;

                if (query.ToList().Count > 0)
                {
                    return query.ToList()[0];
                }
                else
                {
                    return new tblFallecido();
                }
            }
        }

        /// <summary> Elimina un fallecido de la base de datos. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo tblAgraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblFallecido tobjFallecido)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
                {
                    tblFallecido fall_old = personas.tblFallecidos.SingleOrDefault(p => p.intCodigoFal == tobjFallecido.intCodigoFal);
                    fall_old.bitAnulado = true;
                    fall_old.dtmFechaAnu = DateTime.Now;
                    personas.tblLogdeActividades.InsertOnSubmit(tobjFallecido.log);
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

        /// <summary> Consulta si una cedula esta registrada como socio, agraciado o si es particular. </summary>
        /// <param name="tstrCedulaFal"> El número de cédula a evaluar. </param>
        /// <returns> Un string con la procedencia de la cédula. </returns>
        public string gmtdBuscarCedula(string tstrCedulaFal)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from per in personas.tblSocios
                            where per.bitAnulado == false && per.strCedulaSoc == tstrCedulaFal
                            select per;

                if (query.ToList().Count > 0)
                    return "Socio";
                else
                {
                    var queryA = from per in personas.tblAgraciados
                                 where per.bitAnulado == false && per.strCedulaAgra == tstrCedulaFal
                                 select per;

                    if (queryA.ToList().Count > 0)
                        return "Agraciado";
                    else
                        return "Particular";
                }
            }
        }

        /// <summary> Consulta el código de un socio a partir del número de la cédula. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del socio a consultar. </param>
        /// <returns> El código del socio o -1 si no aparece registrada la cédula. </returns>
        public Int32 gmtdConsultarCodigoSocio(string tstrCedulaSocio)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from soc in personas.tblSocios
                            where soc.strCedulaSoc == tstrCedulaSocio && soc.bitAnulado == false
                            select soc;

                if (query.ToList().Count > 0)
                    return query.ToList()[0].intCodigoSoc;
                else
                    return -1;
            }
        }
    }
}
