using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
	[TestClass]
	public class TypeTests
	{
		[TestMethod]
		public void UsingArrays()
		{
			float[] grades;
			grades = new float[3];

			AddGrades(grades);

			Assert.AreEqual(89.1f, grades[1]);
		}

		private void AddGrades(float[] grades)
		{
			grades[1] = 89.1f;
		}

		[TestMethod]
		public void UppercaseString()
		{
			string name = "liam";
			//name.ToUpper();// Won't work because string is immutable and can't be changed. It needs to be assigned.
			name = name.ToUpper();

			Assert.AreEqual("LIAM", name);
		}

		[TestMethod]
		public void AddDaysToDateTime()
		{
			DateTime date = new DateTime(1987, 11, 18);
			//date.AddDays(1); // Won't work because DateTime is immutable and can't be changed. It needs to be assigned.
			date = date.AddDays(1);

			Assert.AreEqual(19, date.Day);
		}

		[TestMethod]
		public void ValueTypesPassByValue()
		{
			int x = 46;
			IncrementNumber(x);

			Assert.AreEqual(46, x);
		}

		private void IncrementNumber(int number)
		{
			number++; //because int is a value type, this isn't x.
		}


		[TestMethod]
		public void ReferenceTypesPassByValue()
		{
			GradeBook book1 = new GradeBook();
			GradeBook book2 = book1;

			GiveBookAName(book2);
			Assert.AreEqual("A Gradebook", book1.Name);
		}

		private void GiveBookAName(GradeBook book)
		{
			//book = new GradeBook(); //This wouldn't change book2.
			book.Name = "A Gradebook";
		}

		[TestMethod]
		public void StringComparisons() 
		{
			string name1 = "Liam";
			string name2 = "liam";

			bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void VariablesHoldAReference()
		{
			GradeBook g1 = new GradeBook();
			GradeBook g2 = g1;
			
			g2.Name = "My Gradebook";
			Assert.AreEqual(g1.Name, g2.Name);
		}

		[TestMethod]
		public void VariablesHoldAValue()
		{
			int integer1 = 5;
			int integer2 = integer1;

			integer2 = 6;
			Assert.AreNotEqual(integer1, integer2);
		}


	}
}
