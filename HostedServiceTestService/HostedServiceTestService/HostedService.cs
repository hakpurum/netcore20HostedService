using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace HostedServiceTestService
{
    public abstract class HostedService : IHostedService, IDisposable
    {
        private Task _currentTask;
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        protected abstract Task ExecuteAsync(CancellationToken cToken);

        //İşleme başla
        public virtual Task StartAsync(CancellationToken cancellationToken)
        {
            //işlemin tamamlanıp tamamlanmadığına bak
            _currentTask = ExecuteAsync(_cancellationTokenSource.Token);
            
            return _currentTask.IsCompleted ? _currentTask : Task.CompletedTask;
        }

        public virtual async Task StopAsync(CancellationToken cancellationToken)
        {
            if (_currentTask == null)
                return;

            try
            {
                _cancellationTokenSource.Cancel();
            }
            finally
            {
                await Task.WhenAny(_currentTask, Task.Delay(Timeout.Infinite, cancellationToken));
            }
        }
        public virtual void Dispose()
        {
            _cancellationTokenSource.Cancel();
        }
    }
}
