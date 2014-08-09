using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using LanguageFeatures.Exceptions;
using System.Threading.Tasks;

namespace Tests.Exceptions
{
    [TestClass]
    public class OperationLogger_Tests
    {
        [TestMethod]
        public async Task Can_Log_A_Successful_Operations()
        {
            var stream = new MemoryStream();
            var logger = new OperationLogger(stream);

            await logger.LogOperation(DoWork);

            Assert.AreEqual("DoWork executed", await ReadStream(stream));

        }

        [TestMethod]
        public async Task Can_Log_A_Failed_Operation()
        {
            var stream = new MemoryStream();
            var logger = new OperationLogger(stream);

            await logger.LogOperation(DoException);

            Assert.AreEqual("DoException failed", await ReadStream(stream));

        }

        async Task<string> ReadStream(Stream stream)
        {
            var reader = new StreamReader(stream);
            stream.Position = 0;
            
            var result = await reader.ReadToEndAsync();
            return result.Trim();
            
        }

        void DoWork()
        {
            // ...
        }

        void DoException()
        {
            throw new InvalidOperationException();
        }
    }
}
