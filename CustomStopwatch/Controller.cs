using System;
namespace CustomStopwatch
{
    public class Controller
    {
        static bool isWorking = false;
        public static void DisplayMenu()
        {
            Console.WriteLine("Start the stopwatch. Enter \'start\'");
            Console.WriteLine("Stop the stopwatch. Enter \'stop\'");
            Console.WriteLine("Exit the stopwatch. Enter \'exit\'");
            Console.WriteLine("Exit the stopwatch. Enter \'reset\'");
            Console.WriteLine("Please follow above guidelines to use the stopwatch");
        }

        public static void Run()
        {
            isWorking = true;
            DisplayMenu();
            while (isWorking)
            {
                var input = Console.ReadLine();
                try
                {
                    switch (input.Trim().ToLower())
                    {

                        case "start":
                            {
                                if (!Stopwatch.HasStarted)
                                {
                                    Stopwatch.Start();
                                }
                                else
                                {
                                    throw new InvalidOperationException("The stopwatch is counting...");
                                }
                            }

                            break;
                        case "stop":
                            {
                                if (Stopwatch.HasStarted && !Stopwatch.HasStopped)
                                {
                                    Stopwatch.Stop();
                                    Console.WriteLine("Time elapsed: " + Stopwatch.GetDuration());
                                    Console.WriteLine("Total time elapsed: " + Stopwatch.GetTotalDuration());
                                }
                                else
                                {
                                    throw new InvalidOperationException("The stopwatch isn\'t counting now.");
                                }

                            }
                            break;
                        case "reset":
                            {
                                Stopwatch.Reset();
                                DisplayMenu();
                            }
                            break;
                        case "exit":
                            {
                                isWorking = false;
                                Console.WriteLine("Thank you for your usage. See you next time!!!");
                                return;
                            }
                        // check valid input
                        default:
                            Console.WriteLine("Invalid Input. Either \'start\' \'stop\' \'reset\' or \'exit\' to be entered");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please follow above guidelines to use the stopwatch");
                }
            }
        }
    }
}
