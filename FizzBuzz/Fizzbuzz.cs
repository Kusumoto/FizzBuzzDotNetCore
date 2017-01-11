using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
	public class Fizzbuss
	{
		private int _number;

		public Fizzbuss(int number)
		{
			this._number = number;
		}

		public string GetMessage()
		{
			var rules = new List<IValidationRules>();
			rules.Add(new FizzBuzzValidation());
			rules.Add(new BuzzValidation());
			rules.Add(new FizzValidation());
			rules.Add(new NonCaseValidation());
			return rules.FirstOrDefault(x => x.IsValid(this._number)).toString();
		}
	}
}
