// See https://aka.ms/new-console-template for more information
Alert alert = new Alert();
alert.Add("Alert #1");
alert.Add("Alert #2");
Console.WriteLine($"Alerts: {alert.ToString()}");

DbPersistence dbPersistence = new DbPersistence();
dbPersistence.Save(alert);

Logging logging = new Logging();
logging.WriteLog(alert);

// ********************************************************************
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
}

public class DbPersistence
{
	public void Save(Alert alert)
	{
		Console.WriteLine($"Saving { alert.Count } alert(s) to database");
	}
}

public class Logging
{
	public void WriteLog(Alert alert)
	{
		Console.WriteLine($"Log: { alert.ToString() }.");
	}
}