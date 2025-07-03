using System;
using System.Threading;

class SmokingProblem
{
    static Semaphore agent = new Semaphore(1, 1);
    static Semaphore tobaccoSmokerSem = new Semaphore(0, 1);
    static Semaphore paperSmokerSem = new Semaphore(0, 1);
    static Semaphore matchSmokerSem = new Semaphore(0, 1);
    static Random rand = new Random();
    static volatile bool isRunning = true;
    static int iterations = 10;

    static void Main()
    {
        // Create threads for the agent and each smoker
        Thread agentThread = new Thread(Agent);
        Thread tobaccoSmoker = new Thread(TobaccoSmoker);
        Thread paperSmoker = new Thread(PaperSmoker);
        Thread matchSmoker = new Thread(MatchSmoker);

        agentThread.Start();
        tobaccoSmoker.Start();
        paperSmoker.Start();
        matchSmoker.Start();

        agentThread.Join();
        isRunning = false;

        tobaccoSmoker.Join();
        paperSmoker.Join();
        matchSmoker.Join();

        Console.WriteLine("Program completed.");
    }

    // Agent thread: Randomly provides two ingredients and signals the appropriate smoker
    static void Agent()
    {
        int count = 0;
        while (count < iterations && isRunning)
        {
            Console.WriteLine($"Agent: Waiting for agent semaphore (iteration {count + 1})");
            agent.WaitOne();
            int choice = rand.Next(3);
            if (choice == 0)
            {
                Console.WriteLine("Agent provides tobacco and paper -> signal smoker with matches");
                matchSmokerSem.Release();
            }
            else if (choice == 1)
            {
                Console.WriteLine("Agent provides paper and matches -> signal smoker with tobacco");
                tobaccoSmokerSem.Release();
            }
            else
            {
                Console.WriteLine("Agent provides tobacco and matches -> signal smoker with paper");
                paperSmokerSem.Release();
            }
            count++;
        }
    }

    // Smoker with tobacco: Waits for paper and matches to smoke
    static void TobaccoSmoker()
    {
        while (isRunning)
        {
            Console.WriteLine("Smoker with tobacco: Waiting for signal...");
            tobaccoSmokerSem.WaitOne();
            if (!isRunning) break;
            Console.WriteLine("Smoker with tobacco smokes");
            Thread.Sleep(rand.Next(100, 200));
            Console.WriteLine("Smoker with tobacco: Releasing agent");
            agent.Release();
        }
    }

    // Smoker with paper: Waits for tobacco and matches to smoke
    static void PaperSmoker()
    {
        while (isRunning)
        {
            Console.WriteLine("Smoker with paper: Waiting for signal...");
            paperSmokerSem.WaitOne();
            if (!isRunning) break;
            Console.WriteLine("Smoker with paper smokes");
            Thread.Sleep(rand.Next(100, 200));
            Console.WriteLine("Smoker with paper: Releasing agent");
            agent.Release();
        }
    }

    // Smoker with matches: Waits for tobacco and paper to smoke
    static void MatchSmoker()
    {
        while (isRunning)
        {
            Console.WriteLine("Smoker with matches: Waiting for signal...");
            matchSmokerSem.WaitOne();
            if (!isRunning) break;
            Console.WriteLine("Smoker with matches smokes");
            Thread.Sleep(rand.Next(100, 200));
            Console.WriteLine("Smoker with matches: Releasing agent");
            agent.Release();
        }
    }
}
