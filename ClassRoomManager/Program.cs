namespace ClassRoomManager;

class Program
{
    static void Main(string[] args)
    {
        //List of tools that will be taught during the program

        Tool[] toolCatalog = new Tool[]
        {
            new Tool { Name = "C#", Description = "Basic Programing", Difficulty = 5 },
            new Tool { Name = "Git", Description = "Source Control", Difficulty = 5 },
            new Tool { Name = "SQL", Description = "Relation Database", Difficulty = 5 },
            new Tool { Name = "Debugging", Description = "Solve problems", Difficulty = 5 },
            new Tool { Name = "Javascript", Description = "Web development", Difficulty = 5 }

        };

        //List of students, empty for now
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Jakob", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
            new Student { Name = "John", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
            new Student { Name = "Mark", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
            new Student { Name = "Erik", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
            new Student { Name = "Frodo", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() }
        };


        List<Student> dotnetCloud25 = new List<Student>()
        {
            new Student { Name = "Bajs", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
            new Student { Name = "Korv", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
            new Student { Name = "Prutt", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
            new Student { Name = "Hans", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
            new Student { Name = "Mordin", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() }
        };


        bool running = true;
        while (running)
        {
            Console.Clear();

            Console.WriteLine("--- ClassRoom Simulator ---");
            System.Console.WriteLine("1. Add student");
            System.Console.WriteLine("2. Presence Check");
            System.Console.WriteLine("3. Run Lecture (Choose Tool)");
            System.Console.WriteLine("4. Show Student List");
            System.Console.WriteLine("5. Show Individual Student Details");
            System.Console.WriteLine("6. Reset Presence Check");
            System.Console.WriteLine("7. Exit Program");
            System.Console.Write("Option: ");
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    ClassRoomHelper.AddStudent(students);
                    break;

                case 2:
                    ClassRoomHelper.PresenceCheck(students);
                    break;

                case 3:
                    ClassRoomHelper.RunLecture(students, toolCatalog);
                    break;

                case 4:
                    ClassRoomHelper.PrintRoster(students);
                    break;

                case 5:
                    ClassRoomHelper.ShowIndividual(students);
                    break;

                case 6:
                    ClassRoomHelper.ResetPresence(students);
                    break;

                case 7:
                    System.Console.WriteLine("Exit Program");
                    running = false;
                    break;

                default:
                    System.Console.WriteLine("Invalid option");
                    break;

            }


        }


    }

}
