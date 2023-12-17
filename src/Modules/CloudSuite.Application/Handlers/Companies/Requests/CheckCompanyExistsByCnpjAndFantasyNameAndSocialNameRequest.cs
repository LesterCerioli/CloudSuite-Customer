using CloudSuite.Application.Handlers.Companies.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Application.Handlers.Companies.Requests
{
    public class CheckCompanyByCnpjAndFantasyNameAndSocialNameRequest : IRequest<CheckCompanyByCnpjAndFantasyNameAndSocialNameResponse>
	{
		public CheckCompanyByCnpjAndFantasyNameAndSocialNameRequest(Guid id, string cnph, string fantasyName, string socialName)
		{
			Id = Guid.NewGuid();
			Cnph = cnph;
			FantasyName = fantasyName;
			SocialName = socialName;
		}

		public Guid Id { get; private set; }

        public string Cnph { get; set; }

        public string FantasyName { get; set; }

        public string SocialName { get; set; }
    }
}
