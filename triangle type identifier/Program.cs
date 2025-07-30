using System;
class Program{
	static void Main(){
		bool terminalCondition = true;
		string results;
		string checker;
		string title = $"""

		*********************************
			TRIANGLE TYPE IDENTIFIER
		*********************************
			
		""";
		string prompt;
		int sideAB;
		int sideBC;
		int sideAC;

		int InputLogic(string inputPrompt){
			try{
				Console.WriteLine(inputPrompt);
				return Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception e){
				Console.WriteLine($"{e.Message}... INPUT is Required");
				return InputLogic(inputPrompt);
			}
			
		}
		string InferenceEngine(int sideAB, int sideBC, int sideAC){
			if(sideAB == sideBC && sideAB == sideAC){
				return "Equilateral";
			}else if(sideAB == sideBC || sideAB == sideAC){
				return "Isosceles";
			}else{
				return "Scalene";
			}
		}


		do{
			Console.WriteLine(title);
			sideAB = InputLogic("Enter the length of side |AB| :");
			sideBC = InputLogic("Enter the length of side |BC| :");
			sideAC = InputLogic("Enter the length of side |AC| :");
			checker = InferenceEngine(sideAB, sideBC, sideAC);
			results = $"""

			+--------------------------+
				TRIANGLE TYPE
			+--------------------------+
				{checker}
			+--------------------------+

			""";
			Console.WriteLine($"{sideAB}, {sideBC}, {sideAC}");
			Console.WriteLine(results);
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