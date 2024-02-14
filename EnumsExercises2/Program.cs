using EnumsExercises2.Entities;

namespace EnumsExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a Nice Trip");
            Comment c2 = new Comment("WoW thats AwesomeSauce :3");

            Post p1 = new Post(
                DateTime.Now,
                "Travelling to new Zeland",
                "I'm going to visit this Wonderful Place",
                12
                );
            p1.addComment(c1);
            p1.addComment(c2);

            Comment c3 = new Comment("CLICK ON MY PROFILE FOR FREE {gex} NOW !!!!!!!!!!!11!!");
            Comment c4 = new Comment("Lmao thats cringe kid i did that when i was 1 and was better lmao get rekt kys");
            Post p2 = new Post(
                DateTime.Now,
                "hey guys i did this",
                "look at the thing i made !!",
                6
                );
            p2.addComment(c3);
            p2.addComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);
        } 
    }
}
