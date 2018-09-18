using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tools
{
    public class FileTools
    {
        public string Path { get; set; }
        private FileStream Stream;
        private BinaryWriter Writer;
        private BinaryReader Reader;
        public bool End
        {
            get
            {
                if (Reader == null)
                    throw new InvalidOperationException();
                return Stream.Position == Stream.Length;
            }
        }
        public void BinWriterOpen()
        {
            if (Reader != null)
                throw new InvalidOperationException();
            Stream = new FileStream(Path, FileMode.Create);
            Writer = new BinaryWriter(Stream);
        }

        public void BinReaderOpen()
        {
            if (Writer != null)
                throw new InvalidOperationException();
            Stream = new FileStream(Path, FileMode.Open);
            Reader = new BinaryReader(Stream);
        }

        public void Close()
        {
            Stream?.Close();
            Stream = null;
            Writer?.Close();
            Writer = null;
            Reader?.Close();
            Reader = null;
        }
        public FileTools(string path) => Path = path;
        public void WriteBinList (List<double> list)
        {
            if (Writer == null)
                throw new InvalidOperationException();
            if (list == null)
                throw new ArgumentNullException();
            Writer.Write(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Writer.Write(list[i]);
            }
        }
        public List<double> ReadBinListDouble()
        {
            if (Reader == null)
                throw new InvalidOperationException();
            List<double> list = new List<double>();
            int N = Reader.ReadInt32();
            for (int i = 0; i < N; i++)
            {
                list.Add(Reader.ReadDouble());
            }
            return list;
        }
        
    }
}
