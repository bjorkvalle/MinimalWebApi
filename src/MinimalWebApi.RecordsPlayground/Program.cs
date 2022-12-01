using MinimalWebApi.RecordsPlayground;

User c1 = new ("Tom", true) { Age=22};
User c2 = c1 with { username="Tim"};// new ("Tom", true);

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c1.Equals(c2));

