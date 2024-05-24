public class Enemy{
    public int hp;
    public int basehp;
    public string name;
 
    public int minDmg;
    public int maxDmg;
    
    public int armor = 1;

    public int Attack(int newPlayerHp)
    {
        Random random = new();

        newPlayerHp -= random.Next(minDmg, maxDmg); 

        if(newPlayerHp < 0) newPlayerHp = 0;

        return newPlayerHp;
    }
}