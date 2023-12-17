﻿using CloudSuite.Application.Core;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Application.Handlers.Companies.Responses
{
	public class CreateCompanyResponse : Response
	{
		public Guid RequestId { get; private set; }

		public bool Exists { get; set; }

		public CreateCompanyResponse(
			Guid requestId, bool exists, ValidationResult result)
		{
			RequestId = requestId;
			Exists = exists;
			foreach (var item in result.Errors)
			{
				this.AddError(item.ErrorMessage);
			}
		}

		public CreateCompanyResponse(
			Guid requestId, string failValidation)
		{
			RequestId = requestId;
			Exists = false;
			this.AddError(failValidation);
		}
	}
}
