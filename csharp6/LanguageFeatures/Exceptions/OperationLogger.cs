using System;
using System.IO;
using System.Threading.Tasks;

// null propogation, await in catch, finally

namespace LanguageFeatures.Exceptions
{
    public class OperationLogger : IDisposable
    {
        public OperationLogger(Stream logStream)
        {
            if (logStream == null)
            {
                throw new ArgumentNullException("logStream");
            }
            _logWriter = new StreamWriter(logStream);
        }

        public async Task LogOperation(Action operation)
        {
            var name = operation?.Method?.Name ?? "no name";

            try
            {
                operation();
                await _logWriter.WriteAsync(name + " executed");
            }
            catch(Exception ex) if(ex.Message != null)
            {
                await _logWriter.WriteAsync(name + " failed");
            }
            finally
            {
                await _logWriter.FlushAsync();
            }            
        }

        readonly StreamWriter _logWriter;
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {                    
                    _logWriter.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
