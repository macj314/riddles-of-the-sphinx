using System;

// Create a console application where the Sphinx asks a riddle and the user must answer the riddle correctly. 
//    If the riddle is answered correctly, the Sphinx asks a second riddle and so on.
// Start with one riddle. If the user answers correctly, the Sphinx is defeated. If the user is incorrect, the Sphinx eats the user.
// Once the application is working with a single riddle, add a few more.
// Try writing a method to randomize which riddle the Sphinx asks.

class RiddleSphinx
{
  static void Main()
  {
    Random random = new Random();
    bool check ;
    string answer;
    int loopIndex;
    string[] riddles = { "What's red and smells like blue paint?", "I can fly but have no wings. I can cry but I have no eyes. Wherever I go, darkness follows me. What am I?", "What is easy to get into, but hard to get out of?" };
    string[] answers = { "red paint", "clouds", "trouble"};
    int contentIndex = random.Next(riddles.Length);
    Console.WriteLine("You stumble accross a great forboding sphinx. It's stare although lifeless, seems to follow you. All of a sudden, you hear a voice.");
    Console.WriteLine("|| " + riddles[contentIndex] + " ||");
    Console.WriteLine("The question echoes in your head. You quickly check your surroundings for anyone that may be lurking in the dark.");
    Console.WriteLine("You find no one. As you remember what was transcribed to you, you notice that the words were clear in your head. That there was no clear point of origin.");
    Console.WriteLine("Stricken by the silence in the room, you call out your answer:");
    for (loopIndex = 0; loopIndex < riddles.Length; loopIndex++){
      Console.WriteLine("Question: " + riddles[contentIndex]);
      answer = Console.ReadLine();
      check = answer == answers[contentIndex];
      if (check){
        Console.WriteLine("Congratulations! You got the answer! Guess you get to live another day.");
      } else {
        Console.WriteLine("Oops, looks like that's the wrong answer. Guess I'll eat you now...");
      }
    }
  }
}