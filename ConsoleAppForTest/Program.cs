using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDB;

namespace ConsoleAppForTest
{
	public class Program
	{
		static void Main(string[] args)
		{
			using (var context = new CinemaContext())
			{
				AccessLevel lvl = new AccessLevel { LevelID = 10, LevelName = "My access" };
				context.AccessLevels.Add(lvl);
				context.SaveChanges();
			}

			Console.WriteLine("I am done!");
			Console.ReadLine();


		}

	}
}
