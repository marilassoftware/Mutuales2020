﻿namespace Mutuales2020.Web.Data
{
    using Mutuales2020.Business;
    using Mutuales2020.DataAccess.Utilidades;
    //using Common.Models;
    using Mutuales2020.Web.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Affiliate> GetAffiliates()
        {
            return this.context.Affiliate.OrderBy(p => p.strNombreAfi);
        }

        public Affiliate GetAffiliate(int id)
        {
            return this.context.Affiliate.Find(id);
        }

        public void AddAffiliate(Affiliate product)
        {
            this.context.Affiliate.Add(product);
        }

        public String AddAffiliateSp(String strInformacion)
        {
            var Resultado = new BusinessAfiliate().UpdateAfiliateInformation(strInformacion);
            return Resultado;
        }

        public void UpdateAffiliate(Affiliate product)
        {
            this.context.Update(product);
        }

        public void RemoveAffiliate(Affiliate product)
        {
            this.context.Affiliate.Remove(product);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool AffiliateExists(int id)
        {
            return this.context.Affiliate.Any(p => p.Id == id);
        }
    }
}
