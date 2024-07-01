using TMake.Terraria;

namespace TMake.IO
{
    public static class BestiaryFile
    {
        public static Bestiary Load(BinaryReader reader)
        {
            Bestiary bestiary = new();

            int numKills = reader.ReadInt32();
            for (int i = 0; i < numKills; i++)
            {
                string key = reader.ReadString();
                int value = reader.ReadInt32();
                bestiary.KillCountsByNpcId[key] = value;
            }

            int numSeen = reader.ReadInt32();
            for (int i = 0; i < numSeen; i++)
            {
                bestiary.WasNearPlayer.Add(reader.ReadString());
            }

            int numChat = reader.ReadInt32();
            for (int i = 0; i < numChat; i++)
            {
                bestiary.ChattedWithPlayer.Add(reader.ReadString());
            }

            return bestiary;
        }
        public static int Save(Bestiary bestiary, BinaryWriter bw)
        {
            // Kill Counts
            bw.Write(bestiary.KillCountsByNpcId.Count);
            foreach (var item in bestiary.KillCountsByNpcId)
            {
                bw.Write(item.Key);
                bw.Write(item.Value);
            }

            // Seen
            bw.Write(bestiary.WasNearPlayer.Count);
            foreach (var item in bestiary.WasNearPlayer)
            {
                bw.Write(item);
            }

            // Chatted
            bw.Write(bestiary.ChattedWithPlayer.Count);
            foreach (var item in bestiary.ChattedWithPlayer)
            {
                bw.Write(item);
            }

            return (int)bw.BaseStream.Position;
        }
    }
}
