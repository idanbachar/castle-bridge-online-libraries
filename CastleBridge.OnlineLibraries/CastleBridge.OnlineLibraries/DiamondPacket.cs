using System;
using System.Collections.Generic;
using System.Text;

namespace CastleBridge.OnlineLibraries {
    
    [Serializable]
    public class DiamondPacket {

        public int X;
        public int Y;
        public int Width;
        public int Height;
        public string TeamName;
        public string Owner;
        public string CurrentLocation;
        public bool Visible;
        public string Key;

        public DiamondPacket(int x, int y, string teamName, string key) {

            X = x;
            Y = y;
            TeamName = teamName;
            Key = key;

            switch (teamName) {
                case "Red":
                    CurrentLocation = "Inside_Red_Castle";
                    break;
                case "Yellow":
                    CurrentLocation = "Inside_Yellow_Castle";
                    break;
            }
        }
    }
}
