using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AmsysMonitor.Utils
{
    public class IniFile
    {
        private readonly string filePath;

        public IniFile(string path)
        {
            filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                path);

            if (!File.Exists(filePath))
            {
                CreateDefaultFile();
            }
        }

        private void CreateDefaultFile()
        {
            File.WriteAllText(filePath,
@"[Monitor]

ProcessName=Amsys2Kocom
ProgramPath=C:\Omnisystem\Amsys21\Amsys2Kocom.exe

CheckInterval=5000
RestartDelay=30
HangTimeout=10

AutoStartMonitor=true
RunWithWindows=false
StartMinimized=true

EnableLog=true

MaxRestartCount=5
",
            Encoding.UTF8);
        }

        public string Read(string key)
        {
            foreach (string line in File.ReadAllLines(filePath))
            {
                string text = line.Trim();

                // 빈 줄
                if (string.IsNullOrWhiteSpace(text))
                    continue;

                // 주석
                if (text.StartsWith(";") || text.StartsWith("#"))
                    continue;

                // 섹션
                if (text.StartsWith("["))
                    continue;

                if (text.StartsWith(key + "="))
                {
                    return text.Substring(key.Length + 1);
                }
            }

            return string.Empty;
        }

        public void Write(string key, string value)
        {
            List<string> lines =
                new List<string>(File.ReadAllLines(filePath));

            bool found = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string text = lines[i].Trim();

                if (text.StartsWith(key + "="))
                {
                    lines[i] = $"{key}={value}";
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                lines.Add($"{key}={value}");
            }

            File.WriteAllLines(
                filePath,
                lines,
                Encoding.UTF8);
        }
    }
}