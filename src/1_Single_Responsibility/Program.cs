// See https://aka.ms/new-console-template for more information

Alert alert = new Alert();
alert.Add("Alert #1");
alert.Add("Alert #2");
Console.WriteLine($"Alerts: {alert.ToString()}");
alert.SaveToDb();
alert.WriteLog();

/// ***********************************************
public class Alert 
{
	private List<string> _alerts = new List<string>();

	public int Count { get { return _alerts.Count(); } }

	public void Add(string name) {
		_alerts.Add(name);
	}

	public override string ToString() 
	{
		return string.Join(", ", _alerts);
	}

	public void SaveToDb() {
		Console.WriteLine($"Saving {_alerts.Count} alert(s) to database");
	}

	public void WriteLog() {
		Console.WriteLine($"Log: { this.ToString() }.");
	}
}