using System;
using System.Linq;
using System.Collections.Generic;

class Program {

  static void Main (string[] args){ 
     char element;
     string aspect_output = null;
     bool isUnknown = false;
     string Answer = null;
     string[] Punctuation = {"Yes", "yes", "no", "No"};
     bool Finish = false;
     List<string> AptitudeList = new List<string>();
     bool allElementsSelected = false;
     string AptitudeFinalList = null;
     string name = null;
     int age = 0;
      Console.WriteLine("Hello User, We're gonna need some information for your registration");
      Console.WriteLine("First: What's your full name?");
      name = Console.ReadLine();
      Console.WriteLine("Second: How old are you?");
      age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Finally, What are your aptitudes?\n" + 
            "\n1.- Pyro" +
            "\n2.- Geo" +
            "\n3.- Aero" +
            "\n4.- Hydro" +
            "\n5.- Ordo" +
            "\n6.- Perditio\n");
            element = Console.ReadLine()[0];
            switch(element){
              case '1': aspect_output = "Fire";
              break;
              case '2': aspect_output = "Earth";
              break;
              case '3': aspect_output = "Air";
              break;
              case '4': aspect_output = "Water";
              break;
              case '5': aspect_output = "Order";
              break;
              case '6': aspect_output = "Entropy";
              break;
              default: isUnknown = true;
              break;
            };

        if(isUnknown != true){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Oh, wow a " + aspect_output + " user...");
        Console.ResetColor();
        AptitudeList.Add(aspect_output);
        Console.WriteLine("Do you have another aptitude?");
        } else {
        Console.WriteLine("Hmm, that is not available in here, Sorry!");
        };
        Answer = Console.ReadLine();
      bool isCorrect;
        if (Punctuation.Contains(Answer)){
            isCorrect = true;
        } else {
          isCorrect = false;
        };
        if(Answer == "Yes" || Answer == "yes"){
          Finish = false;
        } else if (Answer == "No" || Answer == "no") {
          Finish = true;
        }

        if(isCorrect == true && Answer == "Yes" || Answer == "yes"){
          Console.WriteLine("So..., What is it?");
        } else if(isCorrect == true && Answer == "No" || Answer == "no"){
          Console.WriteLine("Oh, well you only are a " + aspect_output + " user...");
        };
     while(Finish != true){
        Console.WriteLine("\n1.- Pyro" +
            "\n2.- Geo" +
            "\n3.- Aero" +
            "\n4.- Hydro" +
            "\n5.- Ordo" +
            "\n6.- Perditio\n");
            element = Console.ReadLine()[0];
            switch(element){
              case '1': aspect_output = "Fire";
              break;
              case '2': aspect_output = "Earth";
              break;
              case '3': aspect_output = "Air";
              break;
              case '4': aspect_output = "Water";
              break;
              case '5': aspect_output = "Order";
              break;
              case '6': aspect_output = "Entropy";
              break;
              default: isUnknown = true;
              break;
            };
        if(isUnknown != true){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Oh, wow a " + aspect_output + " user...");
        Console.ResetColor();
        AptitudeList.Add(aspect_output);
        Console.WriteLine("Do you have another aptitude?");
        } else {
        Console.WriteLine("Hmm, that is not available in here, Sorry!");
        Finish = true;
        };
        Answer = Console.ReadLine();

      if (Punctuation.Contains(Answer)){
            isCorrect = true;
        } else {
          isCorrect = false;
        };
        if(Answer == "Yes" || Answer == "yes"){
          Finish = false;
        } else if (Answer == "No" || Answer == "no") {
          Finish = true;
        }
        switch(AptitudeList.Count){
          case 1: AptitudeFinalList = AptitudeList[0];
          break;
          case 2: AptitudeFinalList = AptitudeList[0] + " & " + AptitudeList[1];
          break;
          case 3: AptitudeFinalList = AptitudeList[0] + ", " + AptitudeList[1] + " & " + AptitudeList[2];
          break;
          case 4:  AptitudeFinalList = AptitudeList[0] + ", " + AptitudeList[1] + ", " + AptitudeList[2] + " & " + AptitudeList[3];
          break;
          case 5: AptitudeFinalList = AptitudeList[0] + ", " + AptitudeList[1] + ", " + AptitudeList[2] + ", " + AptitudeList[3]+ " & " + AptitudeList[4];
          break;
          case 6: AptitudeFinalList = AptitudeList[0] + ", " + AptitudeList[1] + ", " + AptitudeList[2] + ", " + AptitudeList[3]+ ", " + AptitudeList[4] + " & " + AptitudeList[5];
          allElementsSelected = true;
          break;
        }
        if(allElementsSelected == true){
          Console.WriteLine("OMG, you are a person capable of handling all six stones");
          Finish = true;
        };
        if(isCorrect == true && allElementsSelected != true &&Answer == "Yes"|| Answer == "yes"){
          Console.WriteLine("So..., What is it?");
        } else if(isCorrect == true && allElementsSelected != true && Answer == "No" || Answer == "no"){
          Console.WriteLine("Oh, well you are a " + AptitudeFinalList + " master...");
          Finish = true;
        };
  }; //here the while loop ends
  Console.ForegroundColor = ConsoleColor.Red;
  if(allElementsSelected == true){
  Console.WriteLine("You're gonna lead us to the victory");
  };
  Console.ResetColor();
  } //here ends the Main method
} //here ends the class Program