using MultiPlatformFun.Services;

namespace MultiPlatformFun;

public class Worker : BackgroundService
{
    private readonly IMultiPlatformService _service;
    private readonly ILogger<Worker> _logger;

    public Worker(IMultiPlatformService service, ILogger<Worker> logger)
    {
        _service = service;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                _logger.LogInformation("ServiceInfo: {serviceInfo}", _service.ServiceInfo);
            }

            await Task.Delay(1000, stoppingToken);
        }
    }
}