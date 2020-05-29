using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
//using System.Windows.Forms.Timer;

namespace M15Demo_Timing
{
    public partial class Form1 : Form
    {
        #region Timer
        System.Timers.Timer timer = new System.Timers.Timer();
        int seconds = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Elapsed += new ElapsedEventHandler(Countdown);
            timer.Interval = 1000;
            Console.WriteLine($"Konstruktor: {Thread.CurrentThread.ManagedThreadId}");

        }
        void Countdown(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Countdown: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine(seconds--);
            Console.WriteLine($"sender: {sender}"); // Timer selbst
            // damit die textBox aus diesem Thread auch ansprechbar ist, Invoke(Action):
            Invoke(new Action(() =>
            {
                seconds = int.Parse(textBox1.Text);
            }));
            seconds--;
            if (seconds <= 0)
            {
                timer.Stop();
            }
            Invoke(new Action(() =>
            {
                textBox1.Text = seconds.ToString();
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"button1_Click: {Thread.CurrentThread.ManagedThreadId}");

            timer.Start();
        }

        /*
        * Ü: Ü9 kollidierende Buttons + Timer
        */
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Breakfast.PrepareBreakfast();
            Console.WriteLine($"ElapsedMilliseconds: {Breakfast.stopwatch.ElapsedMilliseconds}");
            Console.WriteLine($"ElapsedTicks: {Breakfast.stopwatch.ElapsedTicks}"); // die kleinste Zeiteinheit, mit der gemessen wird
            textBox2.Text += Breakfast.stopwatch.Elapsed; // im Format hh:mm:ss:milliseconds:nanoseconds
        }

    }

    #region Stopwatch
    class Breakfast
    {
        static public Stopwatch stopwatch = new Stopwatch();
        internal static async void PrepareBreakfast()
        {

            Task<List<Ei>> eierTask = BrateEierAsync(2);
            Task<List<Speck>> speckTask = BrateSpeckAsync(3);
            Task<List<Brotscheibe>> brotTask = BrotMitButterUndMarmelade(2);


            // Tasks ausführen / Frühstück servieren
            Saft osaft = SchenkeOsaftEin();
            Console.WriteLine("Osaft ist fertig");

            // gestartete Aufgaben zum Ende bringen, Variante 1
            //List<Brotscheibe> brotscheiben = await brotTask;
            //Console.WriteLine("Brot ist fertig geschmiert");
            //List<Ei> eier = await eierTask;
            //Console.WriteLine("Eier sind fertig");
            //List<Speck> speckscheiben = await speckTask;
            //Console.WriteLine("Speck ist fertig");

            // gestartete Aufgaben zum Ende bringen, Variante 2
            await Task.WhenAll(brotTask, eierTask, speckTask);
            Console.WriteLine("Brot ist fertig geschmiert");
            Console.WriteLine("Eier sind fertig");
            Console.WriteLine("Speck ist fertig");

            Kaffee tasse = SchenkeKaffeeEin();
            Console.WriteLine("Kaffee ist fertig");

            Console.WriteLine("Frühstück ist fertig!");
            
        }

        private static async Task<List<Brotscheibe>> BrotMitButterUndMarmelade(int brotscheibenZahl)
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            var brotscheiben = await ToasteBrotAsync(brotscheibenZahl);
            SchmiereButterAuf(brotscheiben);
            SchmiereMarmeladeAuf(brotscheiben);
            stopwatch.Stop();
            return brotscheiben;

        }

        private static async Task<List<Brotscheibe>> ToasteBrotAsync(int v)
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Brot wird getoastet");
            List<Brotscheibe> brotscheiben = new List<Brotscheibe>();
            for (int i = 0; i < v; i++)
            {
                brotscheiben.Add(new Brotscheibe());
            }
            stopwatch.Stop();
            return brotscheiben;
        }


        private static void SchmiereMarmeladeAuf(List<Brotscheibe> brotscheiben)
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            foreach (var item in brotscheiben)
            {
                Console.WriteLine($"{item} ist mit Marmelade geschmiert");
            }
            stopwatch.Stop();
        }

        private static void SchmiereButterAuf(List<Brotscheibe> brotscheiben)
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            foreach (var item in brotscheiben)
            {
                Console.WriteLine($"{item} ist mit Butter geschmiert");
            }
            stopwatch.Stop();
        }

        private static Saft SchenkeOsaftEin()
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            Console.WriteLine("OSaft wird eingeschenkt");
            Saft osaft = new Saft();
            stopwatch.Stop();
            return osaft;
        }

        private static async Task<List<Speck>> BrateSpeckAsync(int v)
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Speck wird gebraten");
            List<Speck> speckscheiben = new List<Speck>();
            for (int i = 0; i < v; i++)
            {
                speckscheiben.Add(new Speck());
            }
            stopwatch.Stop();
            return speckscheiben;
        }

        private static async Task<List<Ei>> BrateEierAsync(int v)
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Eier werden gebraten");
            List<Ei> eier = new List<Ei>();
            for (int i = 0; i < v; i++)
            {
                eier.Add(new Ei());
            }
            stopwatch.Stop();
            return eier;
        }

        private static Kaffee SchenkeKaffeeEin()
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Kaffee wird eingeschenkt");
            Kaffee kaffee = new Kaffee();
            stopwatch.Stop();
            return kaffee;
        }

        private class Kaffee
        {
        }

        private class Speck
        {
        }

        //mit private 
        private class Ei
        {
        }

        private class Brotscheibe
        {
        }

        private class Saft
        {
        }
    }
    #endregion
}
