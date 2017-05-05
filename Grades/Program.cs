using System;
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

			book.NameChanged += new NameChangedDelegate(OnNameChanged);
			book.NameChanged += new NameChangedDelegate(OnNameChanged2);

			book.Name = "Liam's Grade Book";
			book.AddGrade(91);
			book.AddGrade(21.5f);
			book.AddGrade(80);

			GradeStatistics stats = book.ComputeStatistics();
			Console.WriteLine($"Book Name: {book.Name}");
			WriteResult("Average", stats.AverageGrade);
			WriteResult("Lowest", stats.LowestGrade);
			WriteResult("Highest", stats.HighestGrade);
		}

		static void OnNameChanged(string existingName, string newName)
		{
			Console.WriteLine($"Gradebook changing name from {existingName} to {newName}.");
		}

		static void OnNameChanged2(string existingName, string newName)
		{
			Console.WriteLine($"Gradebook changing name from {existingName} to {newName}.");
		}

		static void WriteResult(string description, int result)
		{
			Console.WriteLine($"{description} Grade: {result}");
		}

		static void WriteResult(string description, float result)
		{
			Console.WriteLine($"{description} Grade: {result}");
		}
	} 
}
