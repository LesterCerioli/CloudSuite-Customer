using CloudSuite.Application.Core;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Application.Handlers.Companies.Responses
{
    public class CreateCompanyResponse : Response
    {
        public Guid Requestid { get; private set; }

        public CreateCompanyResponse(Guid requestid, ValidationResult result)
        {
            Requestid = requestid;
            foreach(var item in result.Errors) {
                this.AddError(item.ErrorMessage);
            }
        }

        public CreateCompanyResponse(Guid requestid, string validationFailure)
        {
            Requestid = requestid;
            this.AddError(validationFailure);
        }
    }
}
