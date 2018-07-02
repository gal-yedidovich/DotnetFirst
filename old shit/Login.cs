public static void Main(string[] args)
{
	string user, pass;
	bool flag = false;
	int i = 0;
            	do {
		Console.WriteLine("Enter User & Pass:");
		user = Console.ReadLine();
		pass = Console.ReadLine();
                		flag = (user == "bubu" && pass == "123");		
		i++;
	} while(i < 3 && !flag);
            
	if(flag)
	{
		Console.WriteLine("Good");
	}
	else 
	{
		Console.WriteLine("Bad");
	}
}