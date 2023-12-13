using NetDevPack.Domain;

namespace CloudSuite.Modules.Commons.ValueObjects
{
    public class Address : ValueObject
    {
        
        [MaxLength(50)]
        public string? StreetAvenue { get; set; }

        
        
        [MaxLength(20)]
        public string? District { get; set; }

        
        [MaxLength(20)]
        public string? Complement { get; set; }

        
        [MaxLength(50)]
        public string? City { get; set; }

        
        [MaxLength(50)]
        public string? State { get; set; }

        [MaxLength(2)]
        public string? UF { get; set; }
        
    }
}