namespace MultiPlatformFun.Services;

public interface IMultiPlatformService
{
    ServiceInfo ServiceInfo { get; }

    void DoSomething();
}