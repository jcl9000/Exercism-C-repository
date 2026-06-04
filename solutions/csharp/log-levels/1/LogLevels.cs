static class LogLine
{
    public static string Message(string logLine)
    {
        string info = "[INFO]:";
        string warning = "[WARNING]:";
        string error = "[ERROR]:";
        string output = logLine.Trim();
        if(output.Contains(info)){
            return output.Replace(info,"").Trim();
        }
        else if(output.Contains(warning)){
            return output.Replace(warning,"").Trim();
        }
        else if(output.Contains(error)){
            return output.Replace(error,"").Trim();
        }
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        string output = logLine.Trim();
        string info = "[INFO]:";
        string warning = "[WARNING]:";
        string error = "[ERROR]:";
            if(output.Contains(info)){
                return "info";
            }
                    else if(output.Contains(warning)){
                return "warning";
            }
                    else if(output.Contains(error)){
                return "error";
            }
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string output = logLine.Trim();
        string info = "[INFO]:";
        string warning = "[WARNING]:";
        string error = "[ERROR]:";
            if(output.Contains(info)){
                string logMessage = output.Replace(info,"").Trim();
                string logLevel = " (info)";
                return logMessage + logLevel;
            }
            else if(output.Contains(warning)){
                string logMessage = output.Replace(warning,"").Trim();
                string logLevel = " (warning)";
                return logMessage + logLevel;
            }
            else if(output.Contains(error)){
                string logMessage = output.Replace(error,"").Trim();
                string logLevel = " (error)";
                return logMessage + logLevel;
            }
        
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
