using CloudSuite.Modules.Domain.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Infrastructure.Mapping.Daooer
{
	public class CompanyDapperMapping
	{
		private readonly IDbConnection _connection;

		public CompanyDapperMapping(IDbConnection connection)
		{
			_connection = connection;
		}

		public async Task<IEnumerable<Company>> GetAllCompaniesAsync()
		{
			var query = @"
                SELECT
                    SocialName,
                    FantasyName,
                    FundationDate,
                    CNPJNumber,
                    StreetOrValue AS StreetAvenue,
                    District,
                    Complement,
                    City,
                    State,
                    UF
                FROM
                    Companies";

			return await _connection.QueryAsync<Company>(query);
		}

		public async Task<Company> GetCompanyByCnpjAsync(string companyCnpj)
		{
			var query = @"
                SELECT 
                    CNPJNumber
                FROM
                    Companies
                WHERE
                    CNPJNumber = @CompanyCnpj";

			return await _connection.QueryFirstOrDefaultAsync<Company>(query, new { CompanyCnpj = companyCnpj });
		}

        public async Task<Company> GetCompanyByFantasyNameAsync(string companyFantasyName)
        {
            var query = @"
                SELECT 
                    FantasyName
                FROM
                    Companies
                WHERE
                    FantasyName = @CompanyFantasyName";

            return await _connection.QueryFirstOrDefaultAsync<Company>(query, new { CompanyFantasyName = companyFantasyName });
        }

        public async Task<Company> GetCompanyBySocialNameAsync(string companySocialName)
        {
            var query = @"
                SELECT 
                    SocialName
                FROM
                    Companies
                WHERE
                    SocialName = @CompanySocialName";

            return await _connection.QueryFirstOrDefaultAsync<Company>(query, new { CompanySocialName = companySocialName });
        }

    }
}
