using CloudSuite.Application.Handlers.Companies.Responses;
using CloudSuite.Modules.Domain.Contracts;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CloudSuite.Application.Handlers.Companies
{
	public class CreateCompanyHandler : IRequestHandler<CreateCompanyCommand, CreateCompanyResponse>
	{
		private readonly ICompanyRepository _companyRepository;
		private readonly ILogger<CreateCompanyHandler> _logger;

		public CreateCompanyHandler(ICompanyRepository companyRepository, ILogger<CreateCompanyHandler> logger)
		{
			_companyRepository = companyRepository;
			_logger = logger;
		}
		
		
		public async Task<CreateCompanyResponse> Handle(CreateCompanyCommand command, CancellationToken cancellationToken)
		{
            //_logger.LogInformation($"CreateCompanyCommand: {JsonSerializer.Serialize(command)}");
			//var validationResult = new CreateCompanyCommandValidation
        }
	}
}
