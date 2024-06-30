using TMake.IO;

namespace TMake.Terraria
{
    public partial class Schematic : TMakeFile, ITileArea
    {
        public override void Load(string filePath)
        {
            SchematicFile.Load(this, filePath);
        }
        public override void Save(string filePath)
        {
            SchematicFile.Save(this, filePath);
        }
    }
}
