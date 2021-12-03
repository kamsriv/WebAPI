using log4net;
public static class ErrLogger
{
    public enum LogType
    {
        DEBUG,
        INFO,
        WARN,
        ERROR,
        FATAL
    }
    private static log4net.ILog log;
    static ErrLogger()
    {
        log = LogManager.GetLogger(typeof(ErrLogger));
    }
    public static void LogMessage(string msg, LogType type)
    {
        switch (type)
        {
            case LogType.DEBUG:
                log.Debug(msg);
                break;
            case LogType.ERROR:
                log.Error(msg);
                break;
            case LogType.WARN:
                log.Warn(msg);
                break;
            case LogType.INFO:
                log.Info(msg);
                break;
            case LogType.FATAL:
                log.Fatal(msg);
                break;
            default:
                log.Debug(msg);
                break;
        }
    }

}