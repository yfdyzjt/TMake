using TMake.IO;

namespace TMake.Terraria
{
    public partial class World : TMakeFile, ITileArea
    {
        public override void Load(string filePath)
        {
            WorldFile.Load(this, filePath);
        }
        public override void Save(string filePath)
        {
            WorldFile.Save(this, filePath);
        }
    }
}
