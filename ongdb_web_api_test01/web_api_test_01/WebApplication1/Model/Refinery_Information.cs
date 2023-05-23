using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1.Model
{
    public class Refinery_Information
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string Customer { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Unit { get; set; }
        public string StartCycleDate { get; set; }
        public string UnitsSelection { get; set; }
        public string RefineryContactName { get; set; }
        public string RefineryContactNumber { get; set; }
        public string RefineryContactEmail { get; set; }
        public string CriterionSalesRepresentativeName { get; set; }
        public string CriterionSalesRepresentativeNumber { get; set; }
        public string CriterionSalesRepresentativeEmail { get; set; }
        public string TechnicalServiceSupportName { get; set; }
        public string TechnicalServiceSupportNumber { get; set; }
        public string TechnicalServiceSupportEmail { get; set; }
    }
}
