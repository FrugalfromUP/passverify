using System;
public class Passwordverifier
{
	public static bool isValid(String password)
	{
		if (!((password.Length >= 8)))
		{
			return false;
		}
		if (password.Contains(" "))
		{
			return false;
		}
		if (true)
		{
			int count = 0;
			for (int i = 0; i <= 9; i++)
			{
			    String str1 = i.ToString();
				if (password.Contains(str1))
				{
					count = 1;
				}
			}
			if (count == 0)
			{
				return false;
			}
		}

		if (true)
		{
			int count = 0;
			for (int i = 65; i <= 90; i++)
			{
				char c = (char)i;

				String str1 = c.ToString();
				if (password.Contains(str1))
				{
					count = 1;
				}
			}
			if (count == 0)
			{
				return false;
			}
		}

		if (true)
		{
			int count = 0;
			for (int i = 97; i <= 122; i++)
			{
				char c = (char)i;
				String str1 = c.ToString();

				if (password.Contains(str1))
				{
					count = 1;
				}
			}
			if (count == 0)
			{
				return false;
			}
		}
		return true;
	}
	public static void Main(String[] args)
	{

		String pass = "RiteshE123";

		if (isValid(pass))
		{
			Console.WriteLine("Valid Password");
		}
		else
		{
			Console.WriteLine("Invalid Password");
		}

	}
}
