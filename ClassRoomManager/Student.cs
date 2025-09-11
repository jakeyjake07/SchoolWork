namespace ClassRoomManager
{
    public class Student
    {
        public string Name;
        public int ProgramingLevel;
        public bool IsPresent;
        public List<Tool> Tools;


        public void LearnTool(Tool tool)
        {
            bool alreadyLearned = false;

            foreach (Tool t in Tools)
            {
                if (t.Name == tool.Name)
                {
                    alreadyLearned = true;
                    break;
                }

            }

            if (!alreadyLearned)
            {
                Tools.Add(tool);
            }
        }

    }
}
