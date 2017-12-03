using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timezone
{

    class Reader : IReader, IDisposable
    {
        public List<Tuple<string, string>> Read()
        {
            List<Tuple<string, string>> lReturn = new List<Tuple<string, string>>();

            string[] fileParts = File.ReadAllText("Timezone.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in fileParts)
            {
                string[] sLineParts = part.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Tuple<string, string> timeZone = new Tuple<string, string>(sLineParts.First(), sLineParts.Last());


                //pull current date and time
                String timeNow = DateTime.Now.ToString();


                //use text file to find time zone for location
                //TimeZoneInfo place = TimeZoneInfo.FindSystemTimeZoneById(sLineParts[1]);

                //calculate time difference
                //DateTime convertedTime = TimeZoneInfo.ConvertTime(timeNow, TimeZoneInfo.Utc,place);

                //split ukDateTime to just display tim                 string[] sUkTime = timeNow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("In the UK the time is ",sUkTime[1]," and the time in ",sLineParts[1]," is ",sLineParts[0]);

                lReturn.Add(timeZone);
            }



            return lReturn;


        }
        public void Dispose()
        {
        }


    }
}