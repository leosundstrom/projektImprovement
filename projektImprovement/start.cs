using projektImprovement;

public class start : LogicClass
{
    stateM stateM;

    List<string> names = new()
    {
        "Leo",
        "Samuel",
        "Richard",
        "Edvin-Chan"
    };

    public start(stateM stateM)
    {
        this.stateM = stateM;
    }

    public override void Update()
    {
        Console.WriteLine("Choose your name, press number yo choose");

        int chooseNumber = 1;
        foreach (string name in names)
        {
            Console.WriteLine($"\n{chooseNumber}. {name}" );
            chooseNumber++;
        }

        Console.ReadLine();

        Console.WriteLine($"Name selected");
        Console.ReadKey();

        
        stateM.currentState = stateM.States.fight;
    }

}