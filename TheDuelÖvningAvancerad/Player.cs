namespace TheDuelÖvningAvancerad
{
    public class Player
    {

        public int Health { get; set; }
        public int Damage { get; set; }

        public string Name { get; set; }

        public Player(int health, int damage, string name)
        {
            Health = health;
            Damage = damage;
            Name = name;
        }

        public string PlayerOneName()
        {
            return Name;
        }
        public int RollDamage()
        {
            // returna random int 
            int damage = 5;
            return damage;

        }


        public int NoDamage()
        {
            Random randomDamage = new Random();

            return randomDamage.Next(0, 0);
        }

        //public int RollCriticalDamage()
        //{
        //    Random critDamage = new Random();

        //    return critDamage.Next(30, 70);
        //}
    }
}
