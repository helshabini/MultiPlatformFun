using System.Runtime.InteropServices;

namespace MultiPlatformFun.Services;

public class MultiplatformService : IMultiPlatformService
{
    public ServiceInfo ServiceInfo { get; } = new()
    {
        OSVersion = Environment.OSVersion.VersionString,
        OSDescription = RuntimeInformation.OSDescription,
        Architecture = RuntimeInformation.OSArchitecture.ToString(),
        RuntimeIdentifier = RuntimeInformation.RuntimeIdentifier,
        Version = Environment.Version.ToString(),
        MachineName = Environment.MachineName,
        UserName = Environment.UserName
    };
    
    public virtual void DoSomething()
    {
        Console.WriteLine("Hello from MultiplatformService!");
    }
}