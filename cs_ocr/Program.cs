// https://velog.io/@rkttu/csharp-win10-ocr-howto

using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Globalization;
using Windows.Graphics.Imaging;
using Windows.Media.Ocr;

namespace ocr
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int argsCount = args.Length;
            
            if (argsCount == 1)
            {
                var language = new Language("ko");
                if (!OcrEngine.IsLanguageSupported(language))
                {
                    throw new Exception($"{ language.LanguageTag } is not supported in this system.");
                }

                var stream = File.OpenRead(args[0]);
                var decoder = await BitmapDecoder.CreateAsync(stream.AsRandomAccessStream());
                var bitmap = await decoder.GetSoftwareBitmapAsync();
                var engine = OcrEngine.TryCreateFromLanguage(language);
                var ocrResult = await engine.RecognizeAsync(bitmap).AsTask();

                Console.WriteLine(ocrResult.Text);
            }
            else
            {
                Console.WriteLine("Usage: cs_ocr.exe {inputFileName}");
            }
        }
    }
}