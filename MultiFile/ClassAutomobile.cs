using System;

public class Automobile
{
	private string _make;
	private string _model;
	private string _trim;

	public Automobile(string Make, string Model, string Trim)
	{
		_make = Make;
		_model = Model;
		_trim = Trim;
	}

	public string Make
    {
		get { return _make; }
		set { _make = value; }
    }

	public string Model
    {
		get { return _model; }
		set { _model = value; }
    }
	public string Trim {
        get { return _trim; }
		set { _trim = value; }
	}


	public void display()
    {
		Console.WriteLine("Vehicle: {0} {1} {2}", _make, _model, _trim);
    }
}
