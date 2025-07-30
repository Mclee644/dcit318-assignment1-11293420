using System;

class Program{
	static void Main(string[] args)
	{
		string prompt = """

		******************
		GRADE CALCULATOR
		******************
		
		""";
		string terminalPrompt;
		int score;
		//KILL SWITCH
		void Terminal(){
			Console.WriteLine("Do you want exit the program: Y/N");
			terminalPrompt = Console.ReadLine().ToUpper();		
		}
		//INPUT
		void Input(){
			Console.WriteLine("Enter your exam score: ");
			score = Convert.ToInt32(Console.ReadLine());
		}
		//MAIN PROGRAM
		do{
		Console.WriteLine(prompt);	
		Input();
		Console.WriteLine(score);
		Terminal();
		}while(terminalPrompt != "Y");
	}
}