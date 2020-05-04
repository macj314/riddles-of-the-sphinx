using System;

class RiddleSphinx
{
  static Random _random = new Random();
  static void Shuffle<T>(T[] array)
  {
    int n = array.Length;
    for (int i = 0; i < (n - 1); i++)
    {
        int r = i + _random.Next(n - i);
        T t = array[r];
        array[r] = array[i];
        array[i] = t;
    }
  }

  static void Main()
  {

    int[] contentIndex = { 0, 1, 2 };
    Shuffle(contentIndex);
    bool check;
    string input;
    int loopIndex = 0;
    string[] riddles = { "What's red and smells like blue paint?", "I can fly but have no wings. I can cry but I have no eyes. Wherever I go, darkness follows me. What am I?", "What is easy to get into, but hard to get out of?" };
    string[] answers = { "red paint", "clouds", "trouble"};
    Console.WriteLine("You stumble accross a great forboding sphinx. It's stare although lifeless, seems to follow you. All of a sudden, you hear a voice.");
    Console.WriteLine("|| " + riddles[contentIndex[loopIndex]] + " ||");
    Console.WriteLine("The question echoes in your head. You quickly check your surroundings for anyone that may be lurking in the dark.");
    Console.WriteLine("You find no one. As you remember what was transcribed to you, you notice that the words were clear in your head. That there was no clear point of origin.");
    Console.WriteLine("Stricken by the silence in the room, you call out your answer:");
    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
    for (loopIndex = 0; loopIndex < riddles.Length; loopIndex++){
      Console.WriteLine("Question: " + riddles[contentIndex[loopIndex]]);
      input = Console.ReadLine();
      check = input == answers[contentIndex[loopIndex]];
      if (check){
        Console.WriteLine("Correct!");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
      } else {
        Console.WriteLine("Oops, looks like that's the wrong answer. Guess I'll eat you now...");
        break;
      }
    }
  }
}