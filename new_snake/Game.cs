using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace new_snake
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime RecordDate { get; set; }
        public Player() { RecordDate = DateTime.Now; }
        public override string ToString()
        {
            string s = Name + " " + Score.ToString() + " " + RecordDate.ToShortDateString();
            return s;
        }
    }
    public class Game
    {
        public List<Player> Players { get; set; }
        public Player curPlayer { get; set; }
        public string SourceFileName = "..\\Highscores.xml";
        
        public Game()
        {
            curPlayer = new Player();
            LoadHighscores(); // check exceptions
        }
        public void SaveHighscores()
        {
            var serializer = new XmlSerializer(typeof(List<Player>));
            using (StreamWriter file = new StreamWriter(SourceFileName))
            {
                serializer.Serialize(file, Players);
            }
        }
        public void LoadHighscores()
        {
            var serializer = new XmlSerializer(typeof(List<Player>));
            try
            {
                using (var sr = new StreamReader(SourceFileName))
                {
                    var listOfDrivers = serializer.Deserialize(sr);
                    Players = listOfDrivers as List<Player>;
                }
            }
            catch(Exception e)
            {
                Players = new List<Player>();
            }
        }
        public void PlayersSort()
        {
            // using Linq
            Players = Players.OrderByDescending(o => o.Score).ToList();
        }
        public int GetBestScore()
        {
            if (Players[0] != null)
                return Players[0].Score;
            return 0;
        }
    }
}
