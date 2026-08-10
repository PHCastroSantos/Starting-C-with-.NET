Thread mainThread = Thread.CurrentThread;
mainThread.Name = "Main Thread";
System.Console.WriteLine(mainThread.Name);

System.Console.WriteLine(mainThread.Name + " is complete!");

Thread thread1 = new Thread(CountDown);
Thread thread2 = new Thread(CountUp);

thread1.Start();
thread2.Start();

static void CountDown()
{
    for(int i = 10; i >= 0; i--)
    {
        System.Console.WriteLine($"Timer #1: {i} seconds");
        Thread.Sleep(1000);
    }
    System.Console.WriteLine("Timer #1 is complete!");
}

static void CountUp()
{
    for(int i = 0; i <= 10; i++)
    {
        System.Console.WriteLine($"Timer #2: {i} seconds");
        Thread.Sleep(1000);
    }
    System.Console.WriteLine("Timer #2 is complete!");
}