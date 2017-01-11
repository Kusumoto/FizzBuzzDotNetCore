namespace FizzBuzz
{
	public class FizzBuzzValidation : IValidationRules
	{
		public bool IsValid(int number)
		{
			return number % 15 == 0;
		}

		public string toString()
		{
			return "Fizz Buzz";
		}
	}
}
