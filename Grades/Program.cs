﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			GradeBook book = new GradeBook();
			book.AddGrade(91);
			book.AddGrade(21.5f);
			book.AddGrade(80);

			GradeStatistics stats = book.ComputeStatistics();
			Console.WriteLine(stats.AverageGrade);
			Console.WriteLine(stats.LowestGrade);
			Console.WriteLine(stats.HighestGrade);

		}
	} 
}
