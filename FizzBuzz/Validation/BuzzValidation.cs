namespace FizzBuzz
{
	public class BuzzValidation : IValidationRules
	{
		public bool IsValid(int number)
		{
			return number % 5 == 0;
		}

		public string toString()
		{
			return "Buzz";
		}
	}
}
