namespace AccountTrackerDB
{
	internal class AccountPersistence
	{
		public int Id { get; set; }
		public string? AccountId { get; set; }
		public string? AccountName { get; set; }
		public string? AccountHolderName { get; set; }
		public decimal CurrentValue { get; set; }
	}
}
