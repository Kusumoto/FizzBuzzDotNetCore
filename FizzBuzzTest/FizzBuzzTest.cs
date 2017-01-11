using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
	[TestFixture()]
	public class FizzBuzzTest
	{
		[Test()]
		public void Fizzbuzz_TestCase_1()
		{
			var fizzBuzz = new Fizzbuss(1);
			Assert.AreEqual("1", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_2()
		{
			var fizzBuzz = new Fizzbuss(2);
			Assert.AreEqual("2", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_3()
		{
			var fizzBuzz = new Fizzbuss(3);
			Assert.AreEqual("Fizz", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_4()
		{
			var fizzBuzz = new Fizzbuss(4);
			Assert.AreEqual("4", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_5()
		{
			var fizzBuzz = new Fizzbuss(5);
			Assert.AreEqual("Buzz", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_6()
		{
			var fizzBuzz = new Fizzbuss(6);
			Assert.AreEqual("Fizz", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_7()
		{
			var fizzBuzz = new Fizzbuss(7);
			Assert.AreEqual("7", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_8()
		{
			var fizzBuzz = new Fizzbuss(8);
			Assert.AreEqual("8", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_9()
		{
			var fizzBuzz = new Fizzbuss(9);
			Assert.AreEqual("Fizz", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_10()
		{
			var fizzBuzz = new Fizzbuss(10);
			Assert.AreEqual("Buzz", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_11()
		{
			var fizzBuzz = new Fizzbuss(11);
			Assert.AreEqual("11", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_12()
		{
			var fizzBuzz = new Fizzbuss(12);
			Assert.AreEqual("Fizz", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_13()
		{
			var fizzBuzz = new Fizzbuss(13);
			Assert.AreEqual("13", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_14()
		{
			var fizzBuzz = new Fizzbuss(14);
			Assert.AreEqual("14", fizzBuzz.GetMessage());
		}
		[Test()]
		public void Fizzbuzz_TestCase_15()
		{
			var fizzBuzz = new Fizzbuss(15);
			Assert.AreEqual("Fizz Buzz", fizzBuzz.GetMessage());
		}
	}
}
