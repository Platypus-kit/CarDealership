namespace Purchase_Service.Domain
{
    public class PurchaseRequest
    {
        public Guid Id { get; set; }
        public string PurchaseStatus { get; set; }
        public bool CarReserve { get; set; }
        public bool CustomerVerification { get; set; }
        public bool ExecutionOfTheTransactionarReserve { get; set; }
        public bool Payment { get; set; }
    }
}
