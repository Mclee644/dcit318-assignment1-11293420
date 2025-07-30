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
		int discountedPrice = 7;
		int age;
		

		do{
			Console.WriteLine(title);
			InputLogic();
			switch(age){
				case >= 65:
					ticketPrice = discountedPrice;
					break;
				case <= 12:
					ticketPrice = discountedPrice;
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

		void InputLogic(){
			try{
				Console.WriteLine("Enter Your Age In Complete Years: ");
				age = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception e){
				Console.WriteLine($"{e.Message}... INPUT is Required!");
				InputLogic();
			}
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