// todo: future
//using System;

//public class User
//{
//    public void Speak()
//    {
//        if (Speaking != null)
//        {
//            Speaking(this, new EventArgs());
//        }
//    }
//    public string Name { get; set; }
//    public event EventHandler<EventArgs> Speaking;
//}

//public class Program
//{
//    public static void Main()
//    {
//        EventHandler<EventArgs> log = (o, e) => Console.Write("hit");

//        var user = new User()
//        {
//            Name = "Scott",
//            Speaking += log
//        };
//    }
//}

