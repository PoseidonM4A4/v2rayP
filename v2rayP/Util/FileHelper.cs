using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2rayP.Util
{
    public class FileHelper
    {
        public static void GzipDecompress(byte[] archive, string filePath)
        {
            byte[] buffer = new byte[4096];
            int n;

            using (var file = File.Create(filePath))
            using (GZipStream input = new GZipStream(new MemoryStream(archive), CompressionMode.Decompress, false))
            while (true)
            {
                n = input.Read(buffer, 0, buffer.Length);
                if (n == 0) break;
                file.Write(buffer, 0, n);
            }
        }

        public static byte[] GzipDecompressToMemory(byte[] archive)
        {
            List<byte> content = new List<byte>();
            byte[] buffer = new byte[4096];
            int n;

            using (GZipStream input = new GZipStream(new MemoryStream(archive), CompressionMode.Decompress, false))
                while (true)
                {
                    n = input.Read(buffer, 0, buffer.Length);
                    if (n == 0) break;

                    if (n == buffer.Length)
                    {
                        content.AddRange(buffer);
                    }
                    else
                    {
                        content.AddRange(buffer.Take(n));
                    }
                }

            return content.ToArray();
        }

        public static string GzipDecompressToString(byte[] archive)
        {
            Encoding encoding = new UTF8Encoding(false);
            return GzipDecompressToString(archive, encoding);
        }

        public static string GzipDecompressToString(byte[] archive, Encoding encoding)
        {
            var decompressedArchive = GzipDecompressToMemory(archive);
            return encoding.GetString(decompressedArchive);
        }

        public static void TouchFile(string path)
        {
            if (!File.Exists(path)) File.Create(path).Close();
        }

        public static bool TouchDirectory(string directory)
        {
            var directoryExist = Directory.Exists(directory);

            if (!directoryExist)
            {
                try
                {
                    Directory.CreateDirectory(directory);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            var isFile = File.Exists(directory);
            return !isFile;
        }
    }
}
