using System;

public class Person
{
	private string _name;
	private string _height;
	private string _weight;
	private string _email;

    public Person(string Name, string Height, string Weight, string Email)
	{
		_name = Name;
		_height = Height;
		_weight = Weight;
		_email = Email;
	}

	public string Nane
    {
		get { return _name; }
		set { _name = value; }
    }

	public string Height
    {
		get { return _height; }
		set { _height = value; }
    }

	public string Weight
    {
		get { return _weight; }
		set { _weight = value; }
    }

	public string Email
	{
		get {return _email; }
		set {_email = value; }
	}
	public void display()
    {
		Console.WriteLine("Name: {0}    Height: {1}    Weight: {2}   Email: {3}", _name, _height, _weight, _email);
    }
}
