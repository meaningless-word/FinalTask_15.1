using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTask_15._1
{
	class Program
	{
		static void Main(string[] args)
		{
			var classes = new[]
			{
				new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
				new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
				new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
			};
			var allStudents = GetAllStudents(classes);

			Console.WriteLine(string.Join(" ", allStudents));
		}

		static string[] GetAllStudents(Classroom[] classes)
		{
			// Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
			string[] students = classes.SelectMany(r => r.Students.Select(x => x)).ToArray();
			return students;
		}

		public class Classroom
		{
			public List<string> Students = new List<string>();
		}
	}
}
