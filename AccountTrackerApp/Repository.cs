namespace AccountTrackerApp
{
	public static class Repository
	{
		private static IPersistence? _persistence;

		public static IPersistence Persistence
		{
			get
			{
				if (_persistence == null)
					throw new NullReferenceException("The persistence layer is not instantiated.");
				else
					return _persistence;
			}
			set => _persistence = value!;
		}
	}
}
