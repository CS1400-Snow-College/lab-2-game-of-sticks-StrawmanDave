// See https://aka.ms/new-console-template for more information

Console.WriteLine("------------------------------");
Console.WriteLine("-Welcome to the game of sticks!-");
Console.WriteLine("------------------------------");

Console.Write("Players will take turns removing sticks between 1 and 3 of the remainging sticks.\nThe player that removes the last stick loses.");
Console.WriteLine(" Press any key to start");
Console.ReadKey();

int sticksLeft = 20;
string Player1 = ("Player 1");
string Player2 = ("Player 2");
string currentPlayer = Player1;

while (sticksLeft > 0)
{
    Console.Write($"It is {currentPlayer}'s turn and there is {sticksLeft} sticks left ");
    int maxTaken = 3;

    if (sticksLeft < 3){
        maxTaken = sticksLeft;
    }
    else {
       maxTaken = 3;
    };

// asks the current player how many sticks they want to take.
    Console.Write($"{currentPlayer} choose a number between 1 and {maxTaken} ");
    string textSticksTaken = Console.ReadLine();
    int takenSticks = Convert.ToInt32(textSticksTaken);


// takes the sticks away.
    if (takenSticks < 1) {
        Console.WriteLine($"You can only take a number of sticks between 1 and {sticksLeft} ");
        Console.WriteLine($"{currentPlayer} choose a number between 1 and {maxTaken}");
    }
    else if (takenSticks > sticksLeft) {
        Console.WriteLine($"You can only take a number of sticks between 1 and {sticksLeft} ");
        Console.WriteLine($"{currentPlayer} choose a number between 1 and {maxTaken}");
    }
    else {
        sticksLeft -= takenSticks;
        Console.WriteLine($"There is now {sticksLeft} sticks left ");
    };
// current player gets changed
    if (currentPlayer == Player1)
    {
        currentPlayer = Player2;
    }
    else 
    {
        currentPlayer = Player1;
    };
};
Console.WriteLine($"{currentPlayer} won!");

