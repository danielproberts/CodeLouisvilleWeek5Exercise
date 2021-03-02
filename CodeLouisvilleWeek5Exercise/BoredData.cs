using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CodeLouisvilleWeek5Exercise
{
    class BoredData
    {
        //JSON Properties
        public string Activity { get; set; }
        public string Type { get; set; }
        public int Participants { get; set; }

        //Get Data From API
        public BoredData pullData(string url)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                BoredData responseData = JsonConvert.DeserializeObject<BoredData>(json);
                return responseData;
            }
        }
    }
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => input.First().ToString().ToUpper() + input.Substring(1)
            };

        public static void CenterTitle(string s)
        {
            string windowHeader = s;
            Console.SetCursorPosition((Console.WindowWidth - windowHeader.Length) / 2, Console.CursorTop);
            Console.WriteLine(windowHeader);
        }
    }
}