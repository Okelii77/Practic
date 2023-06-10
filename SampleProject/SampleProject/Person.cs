namespace SampleProject;

public class Person
{

    //field
    private string _name;


    //property
    public int Id 
    {
        // getter - метод, позволяющий получить значение свойства 
        get;
        // setter - метод, позволяющий задать значение свойства 
        set;
    }
    public Person(int id, string name)
    {
        Id = id;
        _name = name;
    }

    //method
    public string GetName()
    {
        return _name;
    }
}

