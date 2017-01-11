namespace FizzBuzz
{
	public class FizzValidation : IValidationRules
	{
		public bool IsValid(int number)
		{
			return number % 3 == 0;
		}

		public string toString()
		{
			return "Fizz";
		}
	}
}
