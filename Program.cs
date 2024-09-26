// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("------------------------------");
Console.WriteLine("-Welcome to the game of sticks!-");
Console.WriteLine("------------------------------");

Console.Write("Players will take turns removing sticks between 1 and 3 of the remainging sticks.\nThe player that removes the last stick loses.");
Console.WriteLine(" Press any key to start");
Console.ReadKey();

Console.Clear();

int sticksLeft = 20;
string Player1 = ("Player 1");
string Player2 = ("Player 2");
string currentPlayer = Player1;

while (sticksLeft > 0)
{
    Console.WriteLine($"It is {currentPlayer}'s turn and there is {sticksLeft} sticks left ");
    int maxTaken = 3;

    if (sticksLeft < 3){
        maxTaken = sticksLeft;
    }
    else {
       maxTaken = 3;
    };

// asks the current player how many sticks they want to take.
    Console.WriteLine($"{currentPlayer} between 1 and {maxTaken} how many sticks are you taking? ");
    string textSticksTaken = Console.ReadLine();
    int takenSticks = Convert.ToInt32(textSticksTaken);


// takes the sticks away.
    if (takenSticks < 1) {
        Console.WriteLine($"You can only take a number of sticks between 1 and {sticksLeft} ");
        currentPlayer = currentPlayer;
        Console.Write($"{currentPlayer} between 1 and {maxTaken} how many sticks are you taking? ");

    }
    else if (takenSticks > maxTaken) {
        Console.WriteLine($"You can only take a number of sticks between 1 and {sticksLeft} ");
        currentPlayer = currentPlayer;
        Console.Write($"{currentPlayer} between 1 and {maxTaken} how many sticks are you taking? ");
    }
    else {
        sticksLeft -= takenSticks;
        Console.WriteLine($"There is now {sticksLeft} sticks left ");
        Console.Clear();

            if (currentPlayer == Player1)
        {
            currentPlayer = Player2;
        }
        else 
        {
            currentPlayer = Player1;
        };
    };

// current player gets changed
};
Console.WriteLine($"{currentPlayer} won!");