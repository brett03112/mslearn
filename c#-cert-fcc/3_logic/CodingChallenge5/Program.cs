/*
    Make a game using a while loop that simulates you fighting a monster.  Each of you start with 10 health and can 
    attack with 1-10 damage.  The first to lower the other's health to 0 wins.
*/

Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;


while(true)
{
    int heroDamage = random.Next(1, 11);
    monsterHealth -= heroDamage;
    Console.WriteLine($"Monster was damaged and lost {heroDamage} health and now has {monsterHealth} health.");
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
        
    }
    int monsterDamage = random.Next(1, 11);
    heroHealth -= monsterDamage;
    Console.WriteLine($"Hero was damaged and lost {monsterDamage} health and now has {heroHealth} health.");
    if (heroHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
        
    }
}

