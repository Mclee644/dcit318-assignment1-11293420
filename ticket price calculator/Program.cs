using System;

class Program{
	static void Main(string[] args){
		bool terminalCondition = true;
		string title = """

		******************************
		*	TICKET PRICE CALCULATOR	 *
		******************************	

		""";
		string prompt;

		do{
			Console.WriteLine(title);
			Terminal();
		}while(terminalCondition);
		
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