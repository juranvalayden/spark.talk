using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.Services;
public class LoggerService
{
    private readonly string _filePath = "c:/solid/log.txt";

    public void LogError(Exception exception) => File.WriteAllText(_filePath, exception.Message);
}
