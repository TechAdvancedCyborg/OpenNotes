using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OpenNotes
{
    
    public partial class Form1 : Form
    {
        Int32 unixTimestamp;
        private int counter;
        Timer t = new Timer();
        bool firstchange = true;
        System.IO.StreamWriter writer;
        string savelocation = "C:\\tmp\\lastnote.txt";

        public Form1()
        {
            InitializeComponent();
            InitializeMyControl();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            Icon icon = Icon.ExtractAssociatedIcon("icon.ico");
            this.Icon = icon;
        }
        
            private void InitializeMyControl()
        {
            // Put some text into the control first.  
            textBox1.Multiline = true;
            // Add vertical scroll bars to the TextBox control.
            textBox1.ScrollBars = ScrollBars.Vertical;
            // Allow the RETURN key to be entered in the TextBox control.
            textBox1.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            textBox1.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            textBox1.WordWrap = true;
            // Set the default text of the control.
        }
        private static void EnsureDirectoryExists(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            if (!fi.Directory.Exists)
            {
                System.IO.Directory.CreateDirectory(fi.DirectoryName);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {   
            if (firstchange == true)
            {
                Console.WriteLine("FirstChange");
                firstchange = false;
                EnsureDirectoryExists(savelocation);
            }


            System.IO.StreamWriter writer = new System.IO.StreamWriter(savelocation); //open the file for writing.
            writer.Write(textBox1.Text); //write the current date to the file. change this with your date or something.
            writer.Close(); //remember to close the file again.
            writer.Dispose();
            Console.WriteLine("TextChanged");
            Console.WriteLine(unixTimestamp);
        }
        
        

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.



    }
}
