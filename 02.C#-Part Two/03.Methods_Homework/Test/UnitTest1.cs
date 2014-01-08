using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_01;

namespace Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			string pesho = "Pesho";
			string test = Program.Greeting(pesho);
			Assert.AreEqual("Pesho", test);
		}
		[TestMethod]
		public void TestMethod2()
		{
			string pesho = "89";
			string test = Program.Greeting(pesho);
			Assert.AreEqual("89", test);
		}
		[TestMethod]
		public void TestMethod3()
		{
			string pesho = "";
			string test = Program.Greeting(pesho);
			Assert.AreEqual("", test);
		}
	}
}
