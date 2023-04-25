namespace mis_321_pa4.Interfaces
{
    public interface character
    {
        abstract string name {get; set;}
        abstract int power {get; set;}
        abstract double health {get; set;}
        abstract int attackStrength {get; set;}
        abstract int defenceStrength {get; set;}
        
        public void attack(character target);
        public void showStats();
    }
}