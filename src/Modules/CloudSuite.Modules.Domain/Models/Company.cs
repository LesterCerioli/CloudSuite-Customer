using System.Reflection.PortableExecutable;
using CloudSuite.Modules.Commons.ValueObjects;
using NetDevPack.Domain;


namespace CloudSuite.Modules.Domain.Models
{
    public class Company : Entity, IAggregateRoot
    {
        private Cnpj cnpj;
        private DateTime? fundationDate;
        private Address address;

        public Company()
        {
        }

        public Company(Address address, Cnpj cnpj, string? socialName, string? fantasyName, DateTime? fundationDate1, DateTime fundationDate)
        {
            Cnpj = cnpj;
            SocialName = socialName;
            FantasyName = fantasyName;
            FundationDate = fundationDate;
            Address = address;
        }

        public Company(Cnpj cnpj, string? socialName, string? fantasyName, DateTime? fundationDate, Address address)
        {
            this.cnpj = cnpj;
            SocialName = socialName;
            FantasyName = fantasyName;
            this.fundationDate = fundationDate;
            this.address = address;
        }

        public Cnpj Cnpj { get; private set; }

        public string? SocialName { get; private set; }

        public string? FantasyName { get; private set; }

        public DateTime FundationDate { get; private set; }

        public Address Address { get; private set; }

    }
}