// See https://aka.ms/new-console-template for more information

Alert alert = new Alert();
alert.Add("Alert #1");
alert.Add("Alert #2");
Console.WriteLine($"Alerts: {alert.ToString()}");
alert.Save();
alert.Log();


NewAlert newAlert = new NewAlert();
newAlert.Add("Alert #3");
newAlert.Add("Alert #4");
Console.WriteLine($"New Alerts: {newAlert.ToString()}");
Persistence persistence = new Persistence();
persistence.Save(newAlert);
Log log = new Log();
log.WriteLog(newAlert);


/// ***********************************************
public class Alert 
{
    private List<string> _alerts = new List<string>();

    public int Count { get { return _alerts.Count(); } }

    public void Add(string name) {
        _alerts.Add(name);
    }

    public override string ToString() {
        return string.Join(", ", _alerts);
    }

    public void Save() {
        Console.WriteLine($"Saving {_alerts.Count} alert(s) to database");
    }

    public void Log() {
        Console.WriteLine($"Write to the log file..");
    }
}

public class NewAlert 
{
    private List<string> _alerts = new List<string>();

    public int Count { get { return _alerts.Count(); } }

    public void Add(string message) {
        _alerts.Add(message);
    }

    public override string ToString() {
        return string.Join(", ", _alerts);
    }
}

public class Persistence 
{
    public void Save(NewAlert alert) 
    {
        Console.WriteLine($"Saving {alert.Count} alert(s) to database");
    }
}

public class Log
{
    public void WriteLog(NewAlert alert)
    {
        Console.WriteLine($"Write to the log file..");
    }
}