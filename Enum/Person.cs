using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
	public class Person
	{

		private byte _age;
		public string Fullanme { get; set; }



		public byte Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value < 0 || value > 125)
				{
					throw new IboTatlises("sehvdiiii");
				}

				_age = value;
			}
		}

		public Person(byte age,string fullname)
		{
			age = Age;
			fullname = Fullanme;
		}




	}

}




