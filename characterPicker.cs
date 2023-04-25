namespace mis_321_pa4
{
    public class characterPicker
    {
        public static void selection(string selection, user fuck){
            while(selection != "1" && selection != "2" && selection != "3"){
                System.Console.WriteLine("please make a valid selection.");
                selection = Console.ReadLine();
            }
            if(selection == "1"){
                fuck.userCharacter = new jackSparrow();
            }
            else if(selection == "2"){
                fuck.userCharacter = new willTurner();
            }
            else if(selection == "3"){
                fuck.userCharacter = new davyJones();
            }
        }
    }
}