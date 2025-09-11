namespace ClassRoomManager
{

    public static class ClassRoomHelper
    {
        //Case 1
        public static void AddStudent(List<Student> students)
        {
            System.Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Start Level: ");
            int level = int.Parse(Console.ReadLine());

            Student studentToAdd = new Student
            {
                Name = name,
                ProgramingLevel = level,
                IsPresent = false,
                Tools = new List<Tool>()

            };


            students.Add(studentToAdd);
            System.Console.WriteLine($"Student {name} wad added to the list.");
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        //Case 2

        public static void PresenceCheck(List<Student> students)
        {
            if (students.Count == 0)
            {
                System.Console.WriteLine("No students in the list | Press any key to continue...");
                Console.ReadKey();

                return;
            }

            System.Console.WriteLine("Is the student present? (Yes/No) ");
            for (int i = 0; i < students.Count; i++)
            {
                System.Console.Write($"{i + 1}. {students[i].Name}: ");
                string response = Console.ReadLine();
                students[i].IsPresent = (response == "yes" || response == "YES" || response == "Yes");

            }


            System.Console.WriteLine("Presence Check updated | Press any key to continue..");
            System.Console.ReadKey();

        }

        //Case 3
        public static void RunLecture(List<Student> students, Tool[] toolList)
        {
            if (students.Count == 0)
            {
                System.Console.WriteLine("No students in the list | Press any key to continue...");
                Console.ReadKey();
                return;
            }


            System.Console.WriteLine("Choose topic for today: ");
            for (int i = 0; i < toolList.Length; i++)
            {
                Tool t = toolList[i];
                System.Console.WriteLine($"{i + 1}. {t.Name} ({t.Difficulty}) - {t.Description}");
            }

            Console.Write("Choose (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            Tool chosenTool = toolList[choice - 1];
            int level = chosenTool.Difficulty;
            int presentCount = 0;

            foreach (Student student in students)
            {
                if (student.IsPresent)
                {
                    presentCount++;
                    student.ProgramingLevel += level;
                    student.LearnTool(chosenTool);
                }
            }


            if (presentCount > 0)
            {
                System.Console.WriteLine($"Lecture is finished: {chosenTool.Name}, {presentCount} taught. All records have been updated.");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("No students attended. | Press any key to continue...");
                Console.ReadKey();
            }


        }

        //Case 4
        public static void PrintRoster(List<Student> students)
        {
            if (students.Count == 0)
            {
                System.Console.WriteLine("No students in the list.");
                return;
            }

            System.Console.WriteLine("--- Class List ---");
            for (int i = 0; i < students.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {students[i].Name} | Level: {students[i].ProgramingLevel}/100 | Present {students[i].IsPresent} ");
            }

            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();



        }


        //Case 5

        public static void ShowIndividual(List<Student> students)
        {
            if (students.Count == 0)
            {
                System.Console.WriteLine("No students in the list.");
                return;
            }

            for (int i = 0; i < students.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {students[i].Name}");
            }

            System.Console.WriteLine($"Choose student: 1 - {students.Count} ");
            int choice = int.Parse(Console.ReadLine());

            Student student = students[choice - 1];
            System.Console.WriteLine("--- Student Info ---");
            System.Console.WriteLine($"Name: {student.Name}");
            System.Console.WriteLine($"Level: {student.ProgramingLevel}/100");
            System.Console.WriteLine($"Tools: ");

            if (student.Tools.Count == 0)
            {
                System.Console.WriteLine("No tools learned.");
            }

            else
            {
                foreach (Tool tool in student.Tools)
                {
                    System.Console.WriteLine($"- {tool.Name} (Difficulty: {tool.Difficulty}) - {tool.Description}");
                }
            }

            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }




        //Case 6

        public static void ResetPresence(List<Student> students)
        {
            foreach (Student student in students)
            {
                student.IsPresent = false;
            }

            System.Console.WriteLine("Presence was reset | Press any key to continue...");
            Console.ReadKey();
        }






    }





}