using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PracticeSessions
{
    public class TimerClass
    {
       private static Timer timer;

        public void TimerMethods()
        {
            setTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();

            timer.Stop();
            //timer.Enabled = false;

            timer.Dispose();

            Console.WriteLine("Terminating the application...");

        }

        private void setTimer()
        {

            /*Here, we create an instance of the Timer class. We use the constructor to set up a 2000 milliseconds (2 seconds) 
             interval. After that, we use the OnEventExecution static method as our event handler and we assign it to the timer’s 
            Elapsed event. Finally, we call the Start() method so the events start to fire at the defined interval. 
            Another way to start the timer would be to set the Enabled property to true.*/

            // Create a timer with a two second interval.
            timer = new Timer(2000);

            // Hook up the Elapsed event for the timer.
            timer.Elapsed += OnEventExecution;

            /* Whenever we deal with really simple handlers, we can use lambda syntax to shorten the implementation: */
            /*timer.Elapsed += (sender, EventArgs) =>
            {
                Console.WriteLine($"Elapsed event at {EventArgs.SignalTime:G}");
            }; */



            /* Have the timer fire repeated events (true is the default) */
            /* Any newly created timer will repeatedly raise events once started. 
                That’s because the timer’s AutoReset property is set to true by default. */
            timer.AutoReset = true;

            // Start the timer
            timer.Enabled = true;
            //timer.Start();

        }

        private void OnEventExecution(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }

        // The example displays output like the following:
        //       Press the Enter key to exit the application...
        //
        //       The application started at 09:40:29.068
        //       The Elapsed event was raised at 09:40:31.084
        //       The Elapsed event was raised at 09:40:33.100
        //       The Elapsed event was raised at 09:40:35.100
        //       The Elapsed event was raised at 09:40:37.116
        //       The Elapsed event was raised at 09:40:39.116
        //       The Elapsed event was raised at 09:40:41.117
        //       The Elapsed event was raised at 09:40:43.132
        //       The Elapsed event was raised at 09:40:45.133
        //       The Elapsed event was raised at 09:40:47.148
        //
        //       Terminating the application...
    }
}
