using projektImprovement;

public class mainMenu : LogicClass
{
    stateM stateM;

    public mainMenu(stateM stateM)
    {
        this.stateM = stateM;
    }

    public override void Update()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("You're in the city square. Here you can enter the \"inventory\"  items or you could go back to the \"forest\" to fight monsters");
        string pText = Console.ReadLine();
        if (pText.ToLower() == "forest")
        {
            stateM.currentState = stateM.States.fight;
            stateM.SetState();
        }
        if (pText.ToLower() == "inventory")
        {

        }

    }
}