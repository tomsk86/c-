using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace EatME
{
    class BestPlayersList
    {
        public List<Scores> scores = new List<Scores>();
        private XmlSerializer serializer;
        private int nCounter = 0;
        private int x = 5;
        private int z = 25;
        private int y = 22;
        private string path = Directory.GetCurrentDirectory() + "/BestPlayersList.xml";

        public Tuple<int, int, int, int> ResetValues()
        {
            return Tuple.Create(nCounter = 0, x = 5, z = 25, y = 22);
        }

        public void WriteTheFile()
        {
            StreamWriter wr = new StreamWriter(path);
            serializer = new XmlSerializer(typeof(List<Scores>));
            serializer.Serialize(wr, scores);
            wr.Flush();
            wr.Close();
        }
        public void FillTheList(string name, string time)
        {
            scores.Add(new Scores(name, time));
        }
        public void ReadTheFile()
        {
            if (File.Exists(path))
            {
                StreamReader r = new StreamReader(path);
                serializer = new XmlSerializer(typeof(List<Scores>));
                scores = (List<Scores>)serializer.Deserialize(r);
                r.Close();
            }
        }

        public void DisplayList()
        {
            ResetValues();
            if (scores.Count == 0 || !File.Exists(path))
            {
                Console.WriteLine("Lack of records to display");
            }
            else
            {
                Console.SetCursorPosition(14, 20);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("BestPlayersRanking");
                Console.ResetColor();

                scores.Sort();

                foreach (var sortedData in scores)
                {
                    if (nCounter < 10)
                    {
                        Console.SetCursorPosition(0, y);
                        Console.Write(++nCounter + ".");
                        Console.SetCursorPosition(x, y);
                        Console.Write("UserName: {0}", sortedData._name);
                        Console.SetCursorPosition(z, y);
                        Console.WriteLine("   Time: {0}", sortedData._time);
                        y++;
                    }
                }
            }
        }
    }
}
