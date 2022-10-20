//Elizar Garcia
//10-20-22
//Mini Challenge #8 Guess it
//In this console project we will be creating a guessing game


Console.Clear();

string answer = "";
int userInput = 0;

Console.Clear();


Console.WriteLine("Do you want to play a game?");
Console.WriteLine( "Press Enter to play or type in \"QUIT\" to quit." );
string input = Console.ReadLine().ToUpper();
while( input != "QUIT")
{

int count = 0;
Console.WriteLine("Please select a difficulty.");
Console.WriteLine("Type \"EASY: 1-10\" for easy mode.");
Console.WriteLine("Type \"MEDIUM:1-50\" for medium mode.");
Console.WriteLine("Type \"HARD:1-100\" for hard mode.");
string gameMode = Console.ReadLine().ToUpper();



    


if (gameMode == "EASY") 
{
    Random rndNum = new Random();
int num = rndNum.Next(1, 10);
while(userInput != num ){

    

Console.WriteLine("Guess a number bewtween 1-10");

   count++;

 answer = (Console.ReadLine());

 bool answerOne = Int32.TryParse(answer, out userInput);

 if(userInput == 0)
 {
   Console.WriteLine("Invalid entry.");
   break;
   
 }

 if(userInput < num){
    Console.WriteLine("Too Low");

 }
 if (userInput > num)
 {
    Console.WriteLine("Too High");
    
 }else if (userInput == num)
 {
    Console.WriteLine("You Got it!");
    Console.WriteLine("Guess count: " + count);
 }
}
}

if (gameMode == "MEDIUM") 
{
    Random rndNum = new Random();
int num = rndNum.Next(1, 50);
while(userInput != num ){

    

Console.WriteLine("Guess a number bewtween 1-50");

   count++;

 answer = (Console.ReadLine());
 bool answerTWO = Int32.TryParse(answer, out userInput);

 if(userInput == 0)
 {
   Console.WriteLine("Invalid entry");
   break;
 }
 if(userInput < num){
    Console.WriteLine("Too Low");

 }
 if (userInput > num)
 {
    Console.WriteLine("Too High");
    
 }else if (userInput == num)
 {
    Console.WriteLine("You Got it!");
    Console.WriteLine("Guess count: " + count);
 }
}
}


if (gameMode == "HARD") 
{
    Random rndNum = new Random();
int num = rndNum.Next(1, 100);
while(userInput != num ){

    

Console.WriteLine("Guess a number bewtween 1-100");

   count++;

 answer = (Console.ReadLine());
 bool answerThree = Int32.TryParse(answer, out userInput);

 if(userInput == 0)
 {
   Console.WriteLine("Invalid entry");
   break;
 }
 if(userInput < num){
    Console.WriteLine("Too Low");

 }
 if (userInput > num)
 {
    Console.WriteLine("Too High");
    
 }else if (userInput == num)
 {
    Console.WriteLine("You Got it!");
    Console.WriteLine("Guess count: " + count);
 }
}
}

  Console.WriteLine("Press enter to play or type \"QUIT\" to end game.");
  
  input = Console.ReadLine().ToUpper();

}
    Console.WriteLine("Thank you for playing");