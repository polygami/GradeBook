using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
	[TestClass]
	public class GradeBookTest
	{
		[TestMethod]
		public void ComputesHighestGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(10);
			book.AddGrade(90);

			GradeStatistics result = book.ComputeStatistics();
			Assert.AreEqual(90, result.HighestGrade);
		}

		[TestMethod]
		public void ComputesLowestGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(10);
			book.AddGrade(90);

			GradeStatistics result = book.ComputeStatistics();
			Assert.AreEqual(10, result.LowestGrade);
		}

		[TestMethod]
		public void ComputesAverageGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(20);
			book.AddGrade(40);
			book.AddGrade(60);

			GradeStatistics result = book.ComputeStatistics();
			Assert.AreEqual(40, result.AverageGrade);
		}
	}
}
