namespace Mutuales2020.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mutuales2020.Web.Data.Entities;

    public interface IRepository
    {
        void AddAffiliate(Affiliate product);

        String AddAffiliateSp(String strInformacion);

        Affiliate GetAffiliate(int id);

        IEnumerable<Affiliate> GetAffiliates();

        bool AffiliateExists(int id);

        void RemoveAffiliate(Affiliate product);

        Task<bool> SaveAllAsync();

        void UpdateAffiliate(Affiliate product);
    }
}