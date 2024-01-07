namespace MultiPlatformFun;

public class ServiceInfo
{
    public string OSVersion { get; init; } = null!;
    public string OSDescription { get; init; } = null!;
    public string Architecture { get; init; } = null!;
    public string RuntimeIdentifier { get; init; } = null!;
    public string Version { get; init; } = null!;
    public string MachineName { get; init; } = null!;
    public string UserName { get; init; } = null!;
    
    public override string ToString()
    {
        return $"OSVersion: {OSVersion}, OSDescription: {OSDescription}, Architecture: {Architecture}, RuntimeIdentifier: {RuntimeIdentifier}, Version: {Version}, MachineName: {MachineName}, UserName: {UserName}";
    }
}