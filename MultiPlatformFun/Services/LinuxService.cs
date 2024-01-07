namespace MultiPlatformFun.Services;

public class LinuxService : MultiplatformService
{
    public override void DoSomething()
    {
        Console.WriteLine("Hello from LinuxService!");
    }
}