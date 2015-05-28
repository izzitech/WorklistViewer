using System;
using System.IO;

namespace WorklistViewer
{
    class Config 
    {
        string[] config = new string[4];

        public string serverIp
        {
            get
            {
                return config[0].Split(':')[1];
            }
        }

        public ushort serverPort
        {
            get
            {
                return ushort.Parse(config[1].Split(':')[1]);
            }
        }

        public string targetAETitle
        {
            get
            {
                return config[2].Split(':')[1];
            }
        }

        public string localAETitle
        {
            get
            {
                return config[3].Split(':')[1];
            }
        }

        
        public void Read()
        {
            if (File.Exists("config.txt"))
            {
                config = File.ReadAllLines("config.txt");
                return;
            }
            else
            {
                throw new Exception("Can't load config.txt file.");
            }
        }
    }
}
