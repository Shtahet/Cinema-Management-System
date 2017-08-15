using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CinemaDB;
using System.Data.Entity;

namespace ConsoleAppTest2
{
	class Program
	{
		static void Main(string[] args)
		{
			var connection = ConfigurationManager.ConnectionStrings["CinemaConnection"].ConnectionString;


			CinemaContext b = new CinemaBase(connection).Context;
			AccessLevel al = b.AccessLevels.Find(1);
			User u = new User()
			{
				UserMail = "user2@mail.com",
				ShaPass = Encoding.UTF8.GetBytes("pass"),
				FirstName = "Vasia",
				LastName = "Pupkin",
				AccessLevel = al
			};
			b.Users.Add(u);

			b.SaveChanges();
			//CinemaContext cn = new CinemaContext(connection);
			//AccessLevel al2 = cn.AccessLevels.Find(1);
			//cn.AccessLevels.Remove(al2);
			//cn.SaveChanges();
			Console.WriteLine("Done!");
			Console.ReadLine();
		}
	}
}
