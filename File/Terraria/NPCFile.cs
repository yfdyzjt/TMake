using System.Numerics;
using TMake.Terraria;

namespace TMake.IO
{
    public static class NPCFile
    {
        public static NPC[] Load(BinaryReader binaryReader, uint version)
        {
            NPC[] npcs = new NPC[WorldProperty.MaxNPCs];

            bool[] ShimmeredTownNPCs = new bool[(short)NPCID.Count];
            // load shimmerd town
            if (version >= 268)
            {
                int numNpcs = binaryReader.ReadInt32();
                while (numNpcs-- > 0)
                {
                    ShimmeredTownNPCs[binaryReader.ReadInt32()] = true;
                }
            }

            // load npc
            int totalNpcs = 0;
            for (bool i = binaryReader.ReadBoolean(); i; i = binaryReader.ReadBoolean())
            {
                NPC npc = new();
                if (version >= 190)
                {
                    npc.Type = binaryReader.ReadInt32();
                    if (NPCProperty.NpcNames.TryGetValue(npc.Type, out string? value))
                        npc.LegacyName = value;
                }
                else
                {
                    npc.LegacyName = binaryReader.ReadString();
                    if (NPCProperty.NpcIds.TryGetValue(npc.LegacyName, out int value))
                        npc.Type = value;
                }
                npc.GivenName = binaryReader.ReadString();
                npc.Position = new Vector2(binaryReader.ReadSingle(), binaryReader.ReadSingle());
                npc.Homeless = binaryReader.ReadBoolean();
                npc.HomeTileX = binaryReader.ReadInt32();
                npc.HomeTileY = binaryReader.ReadInt32();

                if (version >= 213 && ((BitsByte)binaryReader.ReadByte())[0])
                {
                    npc.TownNpcVariationIndex = binaryReader.ReadInt32();
                }
                npc.TownNPC = true;
                npcs[totalNpcs] = npc;
                totalNpcs++;
            }

            if (version >= 140)
            {
                bool flag = binaryReader.ReadBoolean();
                while (flag)
                {
                    NPC npc = new();
                    if (version >= 190)
                    {
                        npc.Type = binaryReader.ReadInt32();
                    }
                    else
                    {
                        npc.LegacyName = binaryReader.ReadString();
                        if (NPCProperty.NpcIds.TryGetValue(npc.LegacyName, out int value))
                            npc.Type = value;
                    }
                    npc.Position = new Vector2(binaryReader.ReadSingle(), binaryReader.ReadSingle());
                    npcs[totalNpcs] = npc;
                    totalNpcs++;
                    flag = binaryReader.ReadBoolean();
                }
            }
            if (version >= 268)
            {
                for (int i = 0; i < totalNpcs; i++)
                {
                    if (ShimmeredTownNPCs[npcs[i].Type])
                    {
                        npcs[i].ShimmeredTownNPC = true;
                    }
                }
            }

            return npcs;
        }
        public static int Save(IList<NPC> npcs, BinaryWriter bw, uint version)
        {
            var maxNPC = WorldProperty.GetVersionData(version).MaxNpcId;

            if (version >= 268)
            {
                List<int> ShimmeredTownNPCs = [];
                for (int i = 0; i < npcs.Count; i++)
                {
                    if (npcs[i] == null)
                    {
                        continue;
                    }
                    if (npcs[i].ShimmeredTownNPC)
                    {
                        ShimmeredTownNPCs.Add(npcs[i].Type);
                    }
                }

                bw.Write(ShimmeredTownNPCs.Count);
                foreach (int npcID in ShimmeredTownNPCs)
                {
                    bw.Write(npcID);
                }
            }

            foreach (NPC npc in npcs)
            {
                if (npc == null) { continue; }
                if (npc.Type > maxNPC || (!npc.TownNPC || npc.Type == 368)) { continue; }

                bw.Write(true);

                if (version >= 190)
                {
                    bw.Write(npc.Type);
                }
                else
                {
                    bw.Write(npc.LegacyName);
                }

                bw.Write(npc.GivenName);
                bw.Write(npc.Position.X);
                bw.Write(npc.Position.Y);
                bw.Write(npc.Homeless);
                bw.Write(npc.HomeTileX);
                bw.Write(npc.HomeTileY);

                if (version >= 213)
                {
                    BitsByte bitsByte = 0;
                    bitsByte[0] = true;
                    bw.Write(bitsByte);
                    if (bitsByte[0])
                    {
                        bw.Write(npc.TownNpcVariationIndex);
                    }
                }

            }
            bw.Write(false);

            if (version < 140)
                return (int)bw.BaseStream.Position;

            foreach (NPC mob in npcs)
            {
                if (mob == null) { continue; }
                if (mob.Type > maxNPC || (mob.TownNPC && mob.Type != 368)) { continue; }

                bw.Write(true);
                if (version >= 190)
                {
                    bw.Write(mob.Type);
                }
                else
                {
                    bw.Write(mob.LegacyName);
                }
                bw.Write(mob.Position.X);
                bw.Write(mob.Position.Y);
            }
            bw.Write(false);

            return (int)bw.BaseStream.Position;
        }
    }
}
