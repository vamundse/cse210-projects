public class BreathingActivity : Activity
{
    private string _name = "Breathing";
    private string _description = "by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void BreathingExcercise(int sessionTime)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sessionTime);

        Console.Write("The exercise will start in ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        Console.Clear();

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            for (int i = 8; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Clear();
            Console.WriteLine("Breathe Out..");
            for (int i = 8; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}