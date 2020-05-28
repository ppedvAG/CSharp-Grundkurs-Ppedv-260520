using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10Demo_Delegates
{
    public partial class Form1 : Form
    {
        // types
        #region benutzerdefinierter Delegat
        // ein Delegatentyp und damit ein Datentyp, wie eine Klasse
        public delegate int IntIntIntDelegate(int a, int b);
        #endregion

        // fields
        IntIntIntDelegate iiidelegate;
        Func<int, int, int> iiiFuncDelegate;
        List<string> städte = new List<string>() { "Bonn", "Paris", "Nürnberg", "München", "Burghausen" };

        // ctor
        public Form1()
        {
            InitializeComponent();
        }

        // methods
        #region Methoden für Delegaten
        int Addiere(int a, int b)
        {
            MessageBox.Show($"\n Addiere: {a + b}");
            return a + b;
        }
        int Subtrahiere(int a, int b)
        {
            MessageBox.Show($"\n Subtrahiere: {a - b}");
            return a - b;
        }
        #endregion


        #region Einsetzen vom benutzerdef. Del
        private void PlusButton_Click(object sender, EventArgs e)
        {
            iiidelegate = new IntIntIntDelegate(Addiere);
            // Variante 1
            //iiidelegate.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            // Variante 2
            textBox3.Text = iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
        private void MinusButton_Click(object sender, EventArgs e)
        {
            iiidelegate = new IntIntIntDelegate(Subtrahiere);
            textBox3.Text = iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            iiidelegate = new IntIntIntDelegate(Addiere);            
            iiidelegate += Subtrahiere;
            // return vom Delegaten ist das return von der letzten Methode
            textBox3.Text = iiidelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();

        }
        #endregion

        private void VD_PlusBtn_Click(object sender, EventArgs e)
        {
            iiiFuncDelegate = Addiere;
            VD_textBox_Output.Text = iiiFuncDelegate(int.Parse(VD_textBoxZ1.Text), int.Parse(VD_textBoxZ2.Text)).ToString();            
        }

        private void VD_MinusBtn_Click(object sender, EventArgs e)
        {
            iiiFuncDelegate = Subtrahiere;
            VD_textBox_Output.Text = iiiFuncDelegate(int.Parse(VD_textBoxZ1.Text), int.Parse(VD_textBoxZ2.Text)).ToString();
        }

        private void VD_PlusMinusBtn_Click(object sender, EventArgs e)
        {
            // Will mann den Delegaten clearen:
            iiiFuncDelegate = null;
            iiiFuncDelegate = Addiere;
            iiiFuncDelegate += Subtrahiere;
            VD_textBox_Output.Text = iiiFuncDelegate(int.Parse(VD_textBoxZ1.Text), int.Parse(VD_textBoxZ2.Text)).ToString();
        }

        private void AD_FindBtn_Click(object sender, EventArgs e)
        {            
            string gefundeneStadt;

            // anonymer Delegat
            gefundeneStadt = städte.Find(
                delegate (string s)
                {
                    return s.StartsWith("S");
                });

            // Pfeilfunktion
            gefundeneStadt = städte.Find(
                (string s) =>
                {
                    return s.StartsWith("S");
                });

            // Pfeilfunktion kürzer
            gefundeneStadt = städte.Find(s => s.StartsWith("B"));
            // gefundeneStadt = städte.FindLast(s => s.StartsWith("B"));                

            if (gefundeneStadt == null)
                gefundeneStadt = "kein match";
            AD_textBox_Output.Text = gefundeneStadt;
        }


        /*
        * Wenden Sie an der Liste die Methode ForEach(Action) an!
        */
        private void UE_LengthBtn_Click(object sender, EventArgs e)
        {
            städte.ForEach(s => UE_textBox_Output.Text += s.Length + " ");
            // Lösung von Marius
            //städte.ForEach(Zähle);
            //void Zähle(string s) => UE_textBox_Output.Text += (s.Length).ToString();
        }

        


    }
}
