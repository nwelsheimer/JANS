using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using General;

namespace ConsoleCtl
{
    public partial class frmConsole : MetroForm
    {
        public frmConsole()
        {
            InitializeComponent();
            this.Location = new Point(50, 50);
            cnConsole.InternalRichTextBox.KeyUp += ConsoleKeyDown;
        }

        private void frmConsole_Load(object sender, EventArgs e)
        {
            cnConsole.InternalRichTextBox.ReadOnly = false;
            cnConsole.Focus();
            prompt();
        }
        private void ConsoleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = getInput();
                string[] inputParams = input.Split(' ');

                switch (inputParams[0])
                {
                    case "show":
                        cnConsole.WriteOutput(show(inputParams[1]),Color.Red);
                        prompt();
                        break;
                    case "exit":
                        prompt();
                        this.Hide();
                        break;
                    case "quit":
                        this.Close();
                        break;
                    case "debug":
                        debugging();
                        prompt();
                        break;
                    default:
                        cnConsole.WriteOutput("Invalid command, type 'help' for list of commands.\n", Color.Red);
                        prompt();
                        break;
                }
                    
            }
        }
        private void debugging()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            while (!p.HasExited)
                cnConsole.WriteOutput(p.StandardOutput.ReadLine() + "\n", Color.Red);
            cnConsole.WriteOutput("\n", Color.Red);
        }
        private string show(string input)
        {
            string output = "Cannot find variable " + input + ".\n";
            switch (input)
            {
                case "constring":
                    output = Global.SQLCON != null ? Global.SQLCON + "\n" : "Connection string not set yet.\n";
                    break;
            }
            return output;
        }
        private void prompt()
        {
            cnConsole.WriteOutput("jans>", Color.Red);
        }
        private string getInput()
        {
            string input = "     ";
            int line = cnConsole.InternalRichTextBox.Lines.Length - 2;
            while (input.Substring(0,5) != "jans>")
            {
                input = cnConsole.InternalRichTextBox.Lines[line];
                line--;
            }
            return input.Substring(5, input.Length - 5);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
