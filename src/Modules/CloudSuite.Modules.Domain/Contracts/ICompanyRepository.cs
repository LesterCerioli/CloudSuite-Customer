using CloudSuite.Modules.Commons.ValueObjects;
using CloudSuite.Modules.Domain.Models;
namespace CloudSuite.Modules.Domain.Contracts
{
    public interface ICompanyRepository
    {
        Task<Company> GetByCnpj(Cnpj cnpj);

        Task<IEnumerable<Company>> GetList();

        Task Add(Company company);

        void Update(Company company);

        void Remove(Company company);


    }
}