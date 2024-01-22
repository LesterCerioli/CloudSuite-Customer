using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.Application.Core;
using FluentValidation.Results;

namespace CloudSuite.Application.Handlers.Companies.Responses
{
    public class CreateCompanyResponse : Response
    {
        public Guid RequestId { get; private set; }

        public CreateCompanyResponse(Guid requestId, ValidationResult result)
        {
            RequestId = requestId;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }
        public CreateCompanyResponse(Guid requestId, string failValidacao)
        {
            RequestId = requestId;
            this.AddError(failValidacao);
        }
    }
}
