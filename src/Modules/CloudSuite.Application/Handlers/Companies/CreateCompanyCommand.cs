using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyEntity = CloudSuite.Modules.Domain.Models;
using CloudSuite.Application.Handlers.Companies.Responses;

namespace CloudSuite.Application.Handlers.Companies
{
    public class CreateCompanyCommand : IRequest<CreateCompanyResponse>
    {
        public Guid Id { get; private set; }

        public string? SocialName { get; set; }

        public string? FantasyName { get; set; }

        public string? Cnpj { get; set; }

        public DateTime? FundationDate { get; set; }
        
        public CreateCompanyCommand()
        {
            Id = Guid.NewGuid();
        }
        
        public CompanyEntity GetEntity()
        {
            return new CompanyEntity(
                this.SocialName,
                this.FantasyName,
                new Cnpj(this.Cnpj),
                this.FundationDate
            );
        }

        
    }
}
