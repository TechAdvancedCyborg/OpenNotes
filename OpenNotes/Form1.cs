using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenNotes
{
    public partial class Form1 : Form
    {
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
            textBox1.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("TextChanged");
        }
        
        
    }
}
