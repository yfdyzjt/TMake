namespace TMake.IO
{
    public class TMakeFile
    {
        public string Extension
        {
            get => Path.GetExtension(_filePath).TrimStart('.'); 
            set => _filePath = Path.Combine(Directory, FileName + "." + value);
        }
        public string FileName
        {
            get => Path.GetFileNameWithoutExtension(_filePath); 
            set => _filePath = Path.Combine(Directory, value + "." + Extension) ;
        }
        public string Directory
        {
            get => Path.GetDirectoryName(_filePath) ?? ""; 
            set => _filePath = Path.Combine(value, FileName + "." + Extension); 
        }
        public TMakeFileType Type
        {
            get => TMakeFileProperty.GetType(Extension); 
            set => Extension = TMakeFileProperty.GetFileExt(value); 
        }
        public string FilePath
        {
            get => _filePath; 
            set => _filePath = Path.GetFullPath(value); 
        }

        private string _filePath;

        public virtual void Load(string filePath) { }
        public virtual void Save(string filePath) { }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public TMakeFile()
        {
            var type = TMakeFileProperty.GetType(GetType());
            var fileName = GetType().Name;
            var fileExt = TMakeFileProperty.GetFileExt(type);
            _filePath = "TMake" + "_" + fileName + "." + fileExt;
        }
    }
    public class TMakeFileSeachFormat : TMakeFile
    {
        public string ScriptName { get; set; } = "";
        public string FunctionName { get; set; } = "";
    }
}
