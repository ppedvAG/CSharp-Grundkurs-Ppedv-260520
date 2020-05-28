using M05Lab_Fuhrpark;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M12Demo_FileAccess
{
    class Program
    {
        // ohne dieses Attribut kommt die Exception:
        // System.Threading.ThreadStateException: 
        // 'Für den aktuellen Thread muss der STA-Modus (Single Thread Apartment) festgelegt werden,
        // bevor OLE-Aufrufe ausgeführt werden können. 
        // Stellen Sie sicher, dass die Hauptfunktion mit STAThreadAttribute gekennzeichnet ist. 
        // Diese Ausnahme wird nur ausgelöst, wenn ein Debugger mit dem Prozess verbunden ist.'
        [STAThread]
        static void Main(string[] args)
        {
            #region In Datei schreiben
            Transportmittel transportmittel = new Transportmittel("Mercedes", 30000.00, 280);
            string jsonString = JsonConvert.SerializeObject(transportmittel);
            StreamWriter streamWriter = new StreamWriter("Transportmittel.json");
            streamWriter.Write(jsonString);
            // Ohne Close bleibt die Datei leer
            streamWriter.Close();
            #endregion

            #region Aus Datei lesen
            StreamReader streamReader = new StreamReader("Transportmittel.json");
            var objekt = JsonConvert.DeserializeObject<Transportmittel>(streamReader.ReadToEnd());
            streamReader.Close();
            Console.WriteLine($"objekt is Transportmittel: {objekt is Transportmittel}");
            Console.WriteLine($"{objekt.BeschreibeMich()}");
            #endregion

            PKW pkw = new PKW("Audi", 30000.00, 250, 4, 4, 0);
            string fileDB = "FileDB.json";
            //Schreibe(pkw, fileDB);
            Schreibe(pkw);

            Console.WriteLine(
            Lese<PKW>(fileDB).BeschreibeMich()
            );
            Console.ReadKey();
        }
        /*
             * Ü generische Methode Schreibe(arg)
             * 
             */
        static void Schreibe<T>(T o, string datei)
        {
            StreamWriter streamWriter1 = new StreamWriter(datei);
            string jsonString = JsonConvert.SerializeObject(o);
            streamWriter1.Write(jsonString);
            streamWriter1.Close();
        }
        static T Lese<T>(string datei)
        {
            StreamReader streamReader = new StreamReader(datei);
            T objektAusJson = JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
            streamReader.Close();
            return objektAusJson;
        }

        /*
         * Ü2 SaveFileDialog & OpenFileDialog anwenden
         */
        static void Schreibe<T>(T o)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Transportmittel.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter1 = new StreamWriter(saveFileDialog.FileName);
                string jsonString = JsonConvert.SerializeObject(o);
                streamWriter1.Write(jsonString);
                streamWriter1.Close();
            }
        }

        // *todo OpenFileDialog anwenden

        static T Lese<T>()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Transportmittel.json";
            T objektAusJson = default(T);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                objektAusJson = JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                streamReader.Close();
                return objektAusJson;
            }
            return objektAusJson;
            
            
            
        }

        

    }
}
