using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.Application.Handlers.Companies.Responses;
using CloudSuite.Modules.Commons.ValueObjects;
using MediatR;
using CompanyEntity = CloudSuite.Modules.Domain.Models.Company;

namespace CloudSuite.Application.Handlers.Companies
{
    public class CreateCompanyCommand : IRequest<CreateCompanyResponse>
    {
        public Guid Id { get; private set; }

        public string? Cnpj { get; set; }

        public string? SocialName { get; set; }

        public string? FantasyName { get; set; }

        public DateTime? FundationDate { get; set; }

        public string? Endereco { get; set; }

        public CreateCompanyCommand()
        {
            Id = Guid.NewGuid();
        }

        public CompanyEntity GetEntity()
        {
            return new CompanyEntity(
                new Cnpj(this.Cnpj),
                this.SocialName,
                this.FantasyName,
                this.FundationDate,
                new Address(this.Endereco));
                
                
                
            
        }
    }
}
