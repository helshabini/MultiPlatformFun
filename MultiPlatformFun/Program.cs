using System.Runtime.InteropServices;
using MultiPlatformFun;
using MultiPlatformFun.Services;

var builder = Host.CreateApplicationBuilder(args);

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
#if Windows
    builder.Services.AddSingleton<IMultiPlatformService, WindowsService>();
#endif
}
else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
{
#if Linux    
    builder.Services.AddSingleton<IMultiPlatformService, LinuxService>();
#endif
}
else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
#if Mac
    builder.Services.AddSingleton<IMultiPlatformService, MacService>();
#endif
}
else
{
    builder.Services.AddSingleton<IMultiPlatformService, MultiplatformService>();
}

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();