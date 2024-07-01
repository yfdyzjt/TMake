using TMake.Terraria;

namespace TMake.IO
{
    public static class CreativePowerManagerFile
    {
        public static CreativePowerManager Load(BinaryReader binaryReader)
        {
            CreativePowerManager creativePowerManager = new CreativePowerManager();
            while (binaryReader.ReadBoolean())
            {
                var powerId = (CreativePowerId)binaryReader.ReadInt16();

                switch (powerId)
                {
                    case CreativePowerId.time_setfrozen:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadBoolean();
                        break;
                    case CreativePowerId.godmode:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadBoolean();
                        break; ;
                    case CreativePowerId.time_setspeed:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadSingle();
                        break;
                    case CreativePowerId.rain_setfrozen:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadBoolean();
                        break;
                    case CreativePowerId.wind_setfrozen:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadBoolean();
                        break;
                    case CreativePowerId.increaseplacementrange:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadBoolean();
                        break;
                    case CreativePowerId.setdifficulty:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadSingle();
                        break;
                    case CreativePowerId.biomespread_setfrozen:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadBoolean();
                        break;
                    case CreativePowerId.setspawnrate:
                        creativePowerManager.PowersById[(ushort)powerId] = binaryReader.ReadSingle();
                        break;
                }
            }
            return creativePowerManager;
        }
        public static int Save(CreativePowerManager powers, BinaryWriter bw)
        {
            foreach (var item in powers.PowersById)
            {
                bw.Write(true);
                bw.Write(item.Key);

                switch ((CreativePowerId)item.Key)
                {
                    case CreativePowerId.time_setfrozen:
                        bw.Write((bool)item.Value);
                        break;
                    case CreativePowerId.godmode:
                        bw.Write((bool)item.Value);
                        break;
                    case CreativePowerId.time_setspeed:
                        bw.Write((float)item.Value);
                        break;
                    case CreativePowerId.rain_setfrozen:
                        bw.Write((bool)item.Value);
                        break;
                    case CreativePowerId.wind_setfrozen:
                        bw.Write((bool)item.Value);
                        break;
                    case CreativePowerId.increaseplacementrange:
                        bw.Write((bool)item.Value);
                        break;
                    case CreativePowerId.setdifficulty:
                        bw.Write(Math.Clamp((float)item.Value, 0, 1f));
                        break;
                    case CreativePowerId.biomespread_setfrozen:
                        bw.Write((bool)item.Value);
                        break;
                    case CreativePowerId.setspawnrate:
                        bw.Write(Math.Clamp((float)item.Value, 0, 1f));
                        break;
                }
            }
            bw.Write(false);
            return (int)bw.BaseStream.Position;
        }
    }
}
