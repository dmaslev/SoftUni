using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO.Compression;



class ZippingSlicedFiles
{
    private static List<string> files = new List<string>();
    private static MatchCollection matches;

    static void Main()
    {
        string sourceFile = @"../../image.jpg";
        string destinationDirectory = @"../../";
        int parts = 5;

        Slice(sourceFile, destinationDirectory, parts);

        Assemble(files, destinationDirectory);
    }

    private static void Assemble(List<string> files, string destinationDirectory)
    {
        string fileOutputPath = destinationDirectory + "assembled" + "." + matches[0].Groups[2];
        var fsSource = new FileStream(fileOutputPath, FileMode.Create);

        fsSource.Close();

        foreach (var filePart in files)
        {
            using (var inputStream = new FileStream(filePart, FileMode.Open))
            {
                using (var compressionStream = new GZipStream(inputStream, CompressionMode.Decompress, false))
                {
                    using (var outputStream = new FileStream(fileOutputPath, FileMode.Append))
                    {
                        byte[] buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            outputStream.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
        
    }

    private static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            long partSize = (long)Math.Ceiling((double)source.Length / parts);
            long fileOffset = 0;

            string currPartPath;
            FileStream fsPart;
            long sizeRemaining = source.Length;

            string pattern = @"(\w+)(?=\.)\.(?<=\.)(\w+)";
            Regex pairs = new Regex(pattern);
            matches = pairs.Matches(sourceFile);
            for (int i = 0; i < parts; i++)
            {
                currPartPath = destinationDirectory + matches[0].Groups[1] + String.Format(@"-{0}", i)+ ".gz" ;
                files.Add(currPartPath);

                using (fsPart = new FileStream(currPartPath, FileMode.Create))
                {
                    using (var compressionStream = new GZipStream(fsPart, CompressionMode.Compress, false))
                    {
                        byte[] buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }
                            compressionStream.Write(buffer, 0, readBytes);
                        }
                    }
                    
                }
                sizeRemaining = (int)source.Length - (i * partSize);
                if (sizeRemaining < partSize)
                {
                    partSize = sizeRemaining;
                }
                fileOffset += partSize;
            }
        }
    }
}

