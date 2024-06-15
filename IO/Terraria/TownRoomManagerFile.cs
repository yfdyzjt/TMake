using System.Drawing;
using TMake.Terraria;

namespace TMake.IO
{
    public static class TownRoomManagerFile
    {
        public static TownRoomManager[] Load(BinaryReader reader)
        {
            int totalRooms = reader.ReadInt32();
            TownRoomManager[] townRoomManagers = new TownRoomManager[totalRooms];
            for (int i = 0; i < totalRooms; i++)
            {
                int NpcId = reader.ReadInt32();
                Point Home = new(reader.ReadInt32(), reader.ReadInt32());
                townRoomManagers[i] = new TownRoomManager
                {
                    NPCType = NpcId,
                    Home = Home
                };
            }
            return townRoomManagers;
        }
        public static int Save(IList<TownRoomManager> rooms, BinaryWriter bw, uint version)
        {
            var maxNPC = WorldProperty.GetVersionData(version).MaxNpcId;

            var validRoomsForVersion = rooms.Where(r => r.NPCType <= maxNPC).ToList();

            bw.Write(validRoomsForVersion.Count);
            foreach (TownRoomManager room in validRoomsForVersion)
            {
                bw.Write(room.NPCType);
                bw.Write(room.Home.X);
                bw.Write(room.Home.Y);
            }
            return (int)bw.BaseStream.Position;
        }
    }
}
