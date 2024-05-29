//Test2 test2 = new Test2();
//test2.ChangeSomething();

//class Test2 : Test
//{
//    public override void ChangeSomething()
//    {
//        base.ChangeSomething();
//        Console.WriteLine("Ben de bu objenin kopyasıyım.");
//    }

//}


//class Test
//{
//    public virtual void ChangeSomething()
//    {
//        Console.WriteLine("Ben Taner Saydam, bu da örnek kodum.");
//    }
//}


User user1 = new()
{
    Id = 1,
    FirstName = "Taner",
    LastName = "Saydam",
    Email = "tanersaydam@gmail.com"
};

User user2 = new()
{
    Id = 1,
    FirstName = "Taner",
    LastName = "Saydam",
    Email = "tanersaydam@gmail.com"
};

//var result = user1.Equals(user2);
var result = user1 == user2;

Console.WriteLine($"user1 user2'ye eşit mi?: {result}");

Console.ReadLine();

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;

        if (obj is not User user) return false;

        if (obj.GetType() != typeof(User)) return false;

        return user.Id == Id;
    }

    public static bool operator ==(User left, User right) //bu operatör tek yazılamıyor bir de olumsuzunu yazmamız gerekiyor.
    {
        if (left is null || right is null) return false;

        if (left.GetType() != right.GetType()) return false;

        return left.Id == right.Id;
    }

    public static bool operator != (User left, User right)
    {
        if (left is null || right is null) return true;

        if (left.GetType() != right.GetType()) return true;

        return left.Id == right.Id;
    }

}
