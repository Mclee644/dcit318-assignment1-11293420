using System;

class Program{
	static void Main(string[] args)
	{
		string prompt = $"""

		******************
		GRADE CALCULATOR
		******************

		""";
		string terminalPrompt ;
		int score = 0;
		string grade = "N/A";
		string results ;
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

		string GradeChecker(int scoreX){
			if(score >=90 && score <=100){
			grade = "A";
		}
		else if(score >=80 && score <= 89){
			grade = "B";
		}
		else if(score >=70 && score <= 79){
			grade = "C";
		}
		else if(score >= 60 && score <=69){
			grade = "D";
		}
		else if(score >=0 && score < 60 ){
			grade = "F";
		}else {
			Console.WriteLine($"{score}!!!  cross-check the score you entered it is out of range (NB: 0 - 100).");
		}
		return grade;
		}
		//MAIN PROGRAM
		do{
		Console.WriteLine(prompt);	
		Input();

		//decision block
		
		GradeChecker(score);
		
		results = @$"""

		---------------------+
		| SCORE | GRADE  
		+--------------------+
		| {score}	| {grade}
		+--------------------+

		""";
		Console.WriteLine(results);
		Terminal();
		}while(terminalPrompt != "Y");
	}
}