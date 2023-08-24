// allows for the program to repeat
bool checkflag = true;

while (checkflag = true)
{

    bool sucess = false;
    int result = 0;

 // stops null values from passing   
    while (sucess == false)  
    {
                Console.WriteLine("choose your FizzBuzz number");
                sucess = int.TryParse(Console.ReadLine(), out result);
        if (sucess == true)
        {
            break;
        }
                Console.WriteLine("invalid result, try again");
    }
       
  // divisibility check  
    for (int i = 1; i < result; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz - " + i);
        }

        else if (i % 5 == 0) 
        {
            Console.WriteLine("Buzz - " + i);
        }

        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz - " + i);
        }

        else
        {
            Console.WriteLine(i);
        }
    }
    
    //takes input yes or no for repeat + sets checkflag accordingly  
    Console.WriteLine("Play Again");
        string play_again = Console.ReadLine();

        if (play_again == "yes")
        {
            checkflag = true;
        }
        if (play_again == "no")
        {
            checkflag = false;
            break;
        }
}

