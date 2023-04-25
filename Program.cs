using mis_321_pa4;

System.Console.WriteLine("Enter Player One's name.");
user Player1 = new user(Console.ReadLine());
System.Console.WriteLine("Pick " + Player1.name + "'s character.\n1. Jack Sparrow\n2. Will Turner\n3. Davy Jones");
characterPicker.selection(Console.ReadLine(), Player1);
System.Console.WriteLine("Enter Player Two's name.");
user Player2 = new user(Console.ReadLine());
System.Console.WriteLine("Pick " + Player2.name + "'s character.\n1. Jack Sparrow\n2. Will Turner\n3. Davy Jones");
characterPicker.selection(Console.ReadLine(), Player2);
Random roll = new Random();
bool turn = false;
if(roll.Next(0,1) == 1){
    turn = !turn;
}
while(Player1.userCharacter.health > 0 && Player2.userCharacter.health > 0){
    if(turn == true){
        Console.ForegroundColor = ConsoleColor.Red;
        Player1.userCharacter.attack(Player2.userCharacter);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Player2.userCharacter.showStats();
    }
    else{
        Console.ForegroundColor = ConsoleColor.Blue;
        Player2.userCharacter.attack(Player1.userCharacter);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Player1.userCharacter.showStats();
    }
    turn = !turn;
}

Console.ForegroundColor = ConsoleColor.White;

if(Player1.userCharacter.health > 0){
    System.Console.WriteLine(Player1.name + " won!");
}
else{
    System.Console.WriteLine(Player2.name + " won!");
}