using System;

class Program{
	static void Main(string[] args){
		bool terminalCondition = true;
		string title = $"""

		*************************************
			TICKET PRICE CALCULATOR	        
		*************************************	

		""";
		string result;
		string prompt;
		int standardPrice = 10;
		int ticketPrice;
		int discount = 7;
		int age;
		int netPrice = standardPrice - discount; 

		do{
			Console.WriteLine(title);
			Input();
			switch(age){
				case >= 65:
					ticketPrice = netPrice;
					break;
				case <= 12:
					ticketPrice = netPrice;
					break;
				default:
					ticketPrice = standardPrice;
					break;
			}
			result = $"""
			+--------------------------+
			+ AGE	| TICKET PRICE
			+--------------------------+
			+ {age} | GHc {ticketPrice}
			+--------------------------+	

			""";
			Console.WriteLine(result);
			Terminal();
		}while(terminalCondition);

		void Input(){
			Console.WriteLine("Enter Your Age In Complete Years: ");
			age = Convert.ToInt32(Console.ReadLine());
		}
		
		void Terminal(){
			Console.WriteLine("Do You Want To Quit: Y/N");
			prompt = Console.ReadLine().ToUpper();
			if(prompt=="Y"){
				terminalCondition = false;
			}else if(prompt == "N"){
				terminalCondition = true;
			}else{
				Terminal();
			}	
		}
	}
}