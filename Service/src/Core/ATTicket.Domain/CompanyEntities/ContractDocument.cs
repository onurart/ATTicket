namespace ATTicket.Domain.CompanyEntities;
public class ContractDocument : Entity
{
        public  int ContractId { get; set; }
        public string FileName { get; set; }
        public byte[] DocumentData { get; set; }
        public string ContentType { get; set; }

    }
