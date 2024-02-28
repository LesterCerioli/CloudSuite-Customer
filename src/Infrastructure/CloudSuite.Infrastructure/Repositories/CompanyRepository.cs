using CloudSuite.Modules.Commons.ValueObjects;
using CloudSuite.Modules.Domain.Contracts;
using CloudSuite.Modules.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Infrastructure.Repositories
{
	public class CompanyRepository : ICompanyRepository
	{
		
		public CompanyRepository()
		{

		}

		public async Task Add(Company company)
		{
			throw new NotImplementedException();
		}

		public async Task<Company> GetByCnpj(Cnpj cnpj)
		{
			throw new NotImplementedException();
		}

		public async Task<Company> GetByFantasyName(string fantasyName)
		{
			throw new NotImplementedException();
		}

		public async Task<Company> GetBySocialName(string socialName)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Company>> GetList()
		{
			throw new NotImplementedException();
		}

		public void Remove(Company company)
		{
			throw new NotImplementedException();
		}

		public void Update(Company company)
		{
			throw new NotImplementedException();
		}
	}
}
