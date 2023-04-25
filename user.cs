using mis_321_pa4.Interfaces;
namespace mis_321_pa4
{
    public class user
    {
        public string name {get; set;}
        public character userCharacter;

        public user(string name){
            this.name = name;
        }
    }
}