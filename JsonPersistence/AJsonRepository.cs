using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.JsonPersistence
{
    public abstract class AJsonRepository<T> : IDisposable
    {
        private FileInfo fileInfo;
        protected List<T> cache;

        public void InitializeCacheWith(FileInfo jsonFile)
        {
            fileInfo = jsonFile;
            using (var fileReader = new StreamReader(
                new FileStream(fileInfo.FullName, FileMode.OpenOrCreate)))
            {
                var content = fileReader.ReadToEnd();
                cache = JsonConvert.DeserializeObject<List<T>>(content);
            }
        }

        public void Save()
        {
            var jsonWorkDays = JsonConvert.SerializeObject(cache, Formatting.Indented);

            using (var fileWriter = new StreamWriter(fileInfo.FullName))
            {
                fileWriter.Write(jsonWorkDays);
            }
        }

        public void Dispose()
        {
            Save();
        }
    }
}
