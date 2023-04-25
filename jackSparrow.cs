using mis_321_pa4.Interfaces;
namespace mis_321_pa4
{
    public class jackSparrow : character
    {
        public string name {get; set;}
        public int power {get; set;}
        public double health {get; set;}
        public int attackStrength {get; set;}
        public int defenceStrength {get; set;}

        public jackSparrow(){
            Random roll = new Random();
            this.name = "Jack Sparrow";
            this.power = roll.Next(1, 101);
            this.health = 100;
            this.attackStrength = 1;
            this.defenceStrength = 1;
        }
        
        public void attack(character target){
            System.Console.WriteLine(this.name + " attacked " + target.name + " with a distraction!");

            Random roll = new Random();
            this.attackStrength = roll.Next(1, this.power);
            target.defenceStrength = roll.Next(1, target.power);
            if(target.name == "Will Turner"){
                System.Console.WriteLine("CRIT");
                target.health = target.health - (((this.attackStrength) - (target.defenceStrength)) * (1.2)); //This means characters can heal just coding to the powerpoint here
                System.Console.WriteLine("Power: " + (this.attackStrength) + " Damage: " + (this.attackStrength) * (1.2) + " Damage Delt: " +  ((this.attackStrength) - (target.defenceStrength)) * (1.2));
            }
            else{
                target.health = target.health - (((this.attackStrength) - (target.defenceStrength)) * (1));
                System.Console.WriteLine("Power: " + (this.attackStrength) + " Damage: " + (this.attackStrength) * (1) + " Damage Delt: " +  ((this.attackStrength) - (target.defenceStrength)) * (1));
            }
            System.Console.WriteLine("");
        }
        public void showStats(){
            System.Console.WriteLine(this.name + "'s STATS\n----------\nMAX POWER: " + this.power + "\nHEALTH: " + this.health + "\n");
        }
    }
}