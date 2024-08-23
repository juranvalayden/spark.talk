namespace Solid.Principles.Services;

public class ErrorLoggerService
{
    public void LogError(Exception exception) => File.WriteAllText("c:/solid/log.txt", exception.Message);
}
