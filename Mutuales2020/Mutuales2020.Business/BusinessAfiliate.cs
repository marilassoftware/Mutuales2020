namespace Mutuales2020.Business
{
    using Mutuales2020.Business.Utilities;
    using Mutuales2020.DataAccess.Utilidades;
    using System;

    public class BusinessAfiliate
    {
        public String UpdateAfiliateInformation(String strInformacion)
        {
            StoreProcedure sp = new StoreProcedure();
            var Resultado = sp.ExcecuteSp(Sp.uspAffiliateInformationInsert, strInformacion);
            return Resultado;
        }
    }
}
