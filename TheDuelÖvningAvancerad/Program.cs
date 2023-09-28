using TheDuelÖvningAvancerad;

Player playerOne = new(200, 0, "");

Player playerTwo = new(200, 0, "");

// Fråga båda spelarna om sina namn
// Randoma vilken spelare som börjar slåss
// Fråga spelaren om denna vill (A)ttackera, (B)locka, (D)odga. switch-case
// Attack ska ha en random chans att träffa, quick attack, strong attack.
// Dodga ska det finnas en ökad chans att ta bort skadan helt och hållet.
// Blocka ska reducera skadan som den andra spelaren har gjort (*2)
// Implementera så att det finns en crit chans på varje spelare (A)ttack.random
// Printa hur mycket skada den andra spelaren tagit
// När någon spelare dött ska programmet avslutas
// Printa ut vem som vann

Console.WriteLine("*******************************");
Console.WriteLine("***** WELCOME TO THE DUEL *****");
Console.WriteLine("*******************************");
Console.WriteLine("");
Console.WriteLine("Start by typing player ones name!");
Console.Write("Player 1 name: ");
playerOne.Name = Console.ReadLine();

Console.WriteLine("Great! Now input player twos name!");
Console.Write("Player 2 name: ");
playerTwo.Name = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Great! Here are the rules...");
Console.WriteLine();
Console.WriteLine("(A)ttack has a 75% chance of hitting");
Console.WriteLine("(B)lock reduces the next players attack-damage by 50% if its a hit");
Console.WriteLine("(D)odge gives you a 50% chance of dodging the next players attack entirely");

Console.WriteLine();
Console.WriteLine("Now we will randomly generate which player starts");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

Random whichPlayerStarts = new Random();

bool playerOneStarts = whichPlayerStarts.Next(2) == 0;

while (playerOne.Health > 0 && playerTwo.Health > 0)
{
    if (playerOneStarts)
    {
        Console.Clear();
        Console.WriteLine($"The player who starts is {playerOne.Name}");
        Console.WriteLine();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("Choose (A)ttack, (B)lock or (D)odge");
        Console.Write("Input: ");
        string playerInput = Console.ReadLine();
        switch (playerInput)
        {
            case "a":
            case "A":

                int damageDone = Attack(playerOne, playerTwo);
                Console.WriteLine($"{playerOne.Name} hit {playerTwo.Name} for {damageDone} damage);");
                Console.WriteLine();
                Console.WriteLine($"{playerTwo.Name} has {playerTwo.Health} health-points remaining");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                break;

            case "b":
            case "B":

                Block();

                break;

            case "d":
            case "D":

                Dodge();

                break;

        }

    }
    else
    {
        Console.Clear();
        Console.WriteLine($"The player who starts is {playerTwo.Name}");
        Console.WriteLine();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("Choose (A)ttack, (B)lock or (D)odge");
        Console.Write("Input: ");
        string playerInput = Console.ReadLine();
        switch (playerInput)
        {
            case "a":
            case "A":

                int damageDone = Attack(playerTwo, playerOne);
                Console.WriteLine($"{playerTwo.Name} hit {playerOne.Name} for {damageDone} damage);");
                Console.WriteLine();
                Console.WriteLine($"{playerOne.Name} has {playerOne.Health} health-points remaining");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                break;

            case "b":
            case "B":

                Block();

                break;

            case "d":
            case "D":

                Dodge();

                break;


        }

    }
    playerOneStarts = !playerOneStarts;
}


int Attack(Player attackingPlayer, Player attackedPlayer)
{
    Random randomHitChance = new Random();

    int hitChance = randomHitChance.Next(0, 100);

    if (hitChance < 75)
    {
        Console.WriteLine();
        Console.WriteLine("It's a hit! What an absolute unit!!!");
        Console.WriteLine();
        int damage = attackingPlayer.RollDamage();

        attackedPlayer.Health -= damage;

        return damage;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("You missed, noob");
        Console.WriteLine();
        int damage = attackingPlayer.NoDamage();

        attackedPlayer.Health -= damage;

        return damage;
    }
}
void Dodge()
{

}

void Block()
{

}
