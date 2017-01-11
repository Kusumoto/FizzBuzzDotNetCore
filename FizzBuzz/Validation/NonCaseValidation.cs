namespace FizzBuzz
{
	public class NonCaseValidation : IValidationRules
	{
		private int _number;

		public bool IsValid(int number)
		{
			this._number = number;
			return this._number == number;
		}

		public string toString()
		{
			return _number.ToString();
		}
	}
}
