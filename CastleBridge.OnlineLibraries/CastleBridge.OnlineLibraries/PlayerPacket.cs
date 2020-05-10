using System;
using System.Net.Sockets;

namespace CastleBridge.OnlineLibraries {

    [Serializable]
    public class PlayerPacket {

        public string Name;
        public string CharacterName;
        public string TeamName;
        public int CurrentSpeed;
        public RectanglePacket Rectangle;
        public PacketType PacketType;

        public PlayerPacket() {
 

        }
    }
}
