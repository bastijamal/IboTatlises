using System.Security.Cryptography.X509Certificates;

namespace Enum
{
	internal class Program
	{

		static void Main(string[] args)
		{


			try
			{
				Console.WriteLine("full name yaz");
				string fulanme = Console.ReadLine();
				Console.WriteLine("yash yazzz");
				byte age = Convert.ToByte(Console.ReadLine());
				Person person = new Person(age, fulanme);
			}

			catch (FormatException)
			{
				Console.WriteLine("nope");
			}

			catch (OverflowException)
			{
				Console.WriteLine("Overflow");
			}
			catch (IboTatlises)
			{

				Console.WriteLine("duz yaz ay bala");
			}

			catch (Exception ex)
			{
				Console.WriteLine("hayir");
			}
		}
	}
}
