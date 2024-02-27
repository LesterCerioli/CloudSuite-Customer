using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.Infrastructure.Context;
using CloudSuite.Modules.Commons.ValueObjects;
using CloudSuite.Modules.Domain.Contracts;
using CloudSuite.Modules.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudSuite.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository

    {
        protected readonly CustomerDbContext Db;
        protected readonly DbSet<Company> DbSet;

        public CompanyRepository(CustomerDbContext context)
        {
            Db = context;
            DbSet = context.Company;
        }
        
        public async Task<Company> GetByCnpj(Cnpj cnpj)
        {
            return await DbSet.FirstOrDefaultAsync(c => c.Cnpj == cnpj);
        }

        public async Task<IEnumerable<Company>> GetList()
        {
            return DbSet.ToList();
        }

        public void Remove(Company company)
        {
            DbSet.Remove(company);
        }

        public void Update(Company company)
        {
            DbSet.Update(company);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public Task Add(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
