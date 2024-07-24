namespace Exam;

class People
{
    private string name;
    private bool gender;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public bool Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public People(string name, bool gender, int age)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
    }

    public override string ToString()
    {
        return $"Name: {name}, Gender: Female, Age: {age}";
    }
}

