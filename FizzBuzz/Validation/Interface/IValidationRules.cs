using System;
namespace FizzBuzz
{
	public interface IValidationRules
	{
		bool IsValid(int number);
		string toString();
	}
}
