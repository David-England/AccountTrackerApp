namespace AccountTrackerDB
{
	internal class TransactionPersistence
	{
		public int Id { get; set; }
		public string? TransactionId { get; set; }
		public AccountPersistence? SourceAccount { get; set; }
		public AccountPersistence? TargetAccount { get; set; }
		public decimal Amount { get; set; }
	}
}
