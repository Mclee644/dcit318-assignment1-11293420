using System;

class Program{
	static void Main(string[] args){
		int score;
		string grade = "N/A";
		string prompt = """
		Grade Calculator Lite
		... all right reserved.

		""";
		Console.WriteLine(prompt);
		int input(){
			Console.WriteLine("Enter your exams score");
			score = Convert.ToInt32(Console.ReadLine());

			return score;
		}
		/*
		try{
			input();
			if(score <0 || score >100){
				throw new InvalidScore("score is greater than 100 or less than 0");
			}
		}
		catch(Exception){

		}
		catch(InvalidScore){
			Console.WriteLine("try again");
		}
	
		*/
		//do{}
		input();		

		switch(score)
		{
			case <=100:
				grade = "A";
				break;
			case <=89:
				grade = "B";
				break;
			case <=79:
				grade = "C";
				break;
			case <=69:
				grade = "D";
				break;
			case <60:
				grade = "F";
				break;
			default:
				Console.WriteLine("Invalid input '${score}' ");
				break;
		}
		Console.WriteLine($"Grade : {grade}");
	}

}
/*
public class InvalidScore: Exception
{
	public InvalidScore(): base(){}

	public InvalidScore(string message): base(message){}

	public InvalidScore(string messgae, Exception inner): base(message, inner){}
}
*/