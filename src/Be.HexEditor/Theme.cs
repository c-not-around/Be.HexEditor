using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;


namespace Be.HexEditor
{
    internal class Theme
    {
        private Dictionary<string, Color> _Dictionary;

        public Theme(string file)
        {
            _Dictionary = new Dictionary<string, Color>();

            Regex regex = new Regex(@"^[a-zA-Z](\w|-)+(\w|\d)\s*:\s*(\d{1,3}\s*;\s*){3}\d{1,3}\s*$");

            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                int comment = line.IndexOf('#');
                if (comment != -1)
                {
                    line = line.Substring(0, comment);
                }

                line = Regex.Replace(line, @"\s", "");

                if (regex.IsMatch(line))
                {
                    int      colon = line.IndexOf(':');
                    string   key   = line.Substring(0, colon);
                    string[] parts = line.Substring(colon+1).Split(';');
                    Color    color = Color.FromArgb(Convert.ToByte(parts[0]), Convert.ToByte(parts[1]), 
                                                    Convert.ToByte(parts[2]), Convert.ToByte(parts[3]));

                    _Dictionary.Add(key, color);
                }
            }
        }

        public Color this[string key] => _Dictionary.ContainsKey(key) ? _Dictionary[key] : Color.Empty;
    }
}
