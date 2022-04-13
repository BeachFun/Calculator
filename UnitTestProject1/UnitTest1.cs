using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calcul;


namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Sum_10_5_15()
		{
			double n1 = 10d;
			double n2 = 5d;
			double n3 = 15d;

			Assert.AreEqual(n3, Form1.sum(n1, n2));
		}

		[TestMethod]
		public void Razn_10_5_5()
		{
			double n1 = 10d;
			double n2 = 5d;
			double n3 = 5d;

			Assert.AreEqual(n3, Form1.razn(n1, n2));
		}

		[TestMethod]
		public void Del_10_5_2()
		{
			double n1 = 10d;
			double n2 = 5d;
			double n3 = 2d;

			Assert.AreEqual(n3, Form1.del(n1, n2));
		}

		[TestMethod]
		public void Umnog_10_5_50()
		{
			double n1 = 10d;
			double n2 = 5d;
			double n3 = 50d;

			Assert.AreEqual(n3, Form1.umnog(n1, n2));
		}

		[TestMethod]
		public void Step_2_5_32()
		{
			double n1 = 2d;
			double n2 = 5d;
			double n3 = 32d;

			Assert.AreEqual(n3, Form1.step(n1, n2));
		}

		[TestMethod]
		public void Koren_16_2_4()
		{
			double n1 = 16d;
			double n2 = 2d;
			double n3 = 256d;

			Assert.AreEqual(n3, Form1.step(n1, n2));
		}
	}
}
