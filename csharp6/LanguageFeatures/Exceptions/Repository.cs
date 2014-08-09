using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace LanguageFeatures.Exceptions
{
    public class Repository
    {
        public async Task<string> Read(string path)
        {
                try
                {
                using (var stream = File.Open(path, FileMode.Open))
                using (var reader = new StreamReader(stream))
                {
                    var content = await reader.ReadToEndAsync();
                    return content;
                }
            }
            catch (FileNotFoundException ex)
                if(ex.FileName == "foo.txt")
            {
                var x = 1;
                var name = nameof(x);
                using (var stream = File.Open(path, FileMode.Open))
                using (var reader = new StreamReader(stream))
                {
                    await reader.ReadToEndAsync();
                }
            }
            return "";
        }

    }
}
