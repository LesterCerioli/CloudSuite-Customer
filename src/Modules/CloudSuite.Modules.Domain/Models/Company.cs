using CloudSuite.Modules.Commons.ValueObjects;
using NetDevpack.Domain;


namespace CloudSuite.Modules.Domain.Models
{
    public class Company : Entity, IAggregateRoot
    {
        

		public Company(Cnpj cnpj, string? socialName, string? fantasyName, DateTime fundationDate)
        {
            Cnpj = cnpj;
            SocialName = socialName;
            FantasyName = fantasyName;
            FundationDate = fundationDate;
        }

        public Cnpj Cnpj { get; private set; }

        public string? SocialName { get; private set; }

        public string? FantasyName { get; private set; }

        public DateTime FundationDate { get; private set; }

        public Address Address { get; set; }

    }
}