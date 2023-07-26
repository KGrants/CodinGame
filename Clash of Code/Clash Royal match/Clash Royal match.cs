using System;

class Solution
{
    static void Main(string[] args)
    {
        int health = int.Parse(Console.ReadLine());
        int level = int.Parse(Console.ReadLine());

        int fireballDamage = 200 + (level - 1) * 20;
        int remainingHealth = health - fireballDamage;

        if(remainingHealth > 0){Console.Write("rawr " + remainingHealth);}
        else{Console.Write("hehehehaw " + remainingHealth);} 
    }
}
