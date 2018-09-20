namespace cs_day_1.Models
{

  public class User
  {
    // public = accessor, string = data type, name = name of variable 
    // this is a field, you should use a property(under the hood creates a field where you can pre-manipulate it)
    // property below creates = (protected string name;)
    // create a property using 'prop' hotkey
    // *** notice how properties have a name Capitalized and a field doesnt? hmmmmmmm....
    public string Name { get; set; }
    public int Age { get; private set; }

    public bool IsAlive { get; set; }

    public void Birthday()
    {
      Age++;
    }

    // create this method using hotkey 'ctor'
    // you need to declare a parameters data type & name
    public User(string name, int age)
    {
      Name = name;
      Age = age;
      IsAlive = true;
    }



  }

}