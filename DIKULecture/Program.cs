namespace DIKULecture{
    class Program{
        static void Main(string[] args) {
            Speaker Boris = new Speaker();
            Speaker Fritz = new Speaker();
            Student Lucas = new Student();
            Student Marcus = new Student();
            Student Sebastian = new Student();
            Lecture Lecture1 = new Lecture("Softwareudvikling");
            Lecture Lecture2 = new Lecture("Lineær algebra");

            Console.WriteLine("Instances for 2 speakers, 3 students, and 2 lectures have been"
                + "created");
            Console.WriteLine("");
            Console.WriteLine("The Lectures are as follows:");
            Console.WriteLine(Lecture1);
            Console.WriteLine("");
            Console.WriteLine(Lecture2);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The names of the 2 speakers are as follows:");
            Console.WriteLine("Boris");
            Console.WriteLine("Fritz");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The names of the 3 students are as follows:");
            Console.WriteLine("Lucas");
            Console.WriteLine("Marcus");
            Console.WriteLine("Sebastian");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Speaker Boris will now try to change the name of Lecture 1:");
            Boris.ChangeLectureName(Lecture1, "Interaktionsdesign");
            Console.WriteLine("");
            Console.WriteLine("Lecture1's name after Boris tried to change the name:");
            Console.WriteLine(Lecture1.getName());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Student Lucas will now try to join Lecture1:");
            Console.WriteLine("Is Student Lucas currently in a Lecture (before joining): "
                + Lucas.getLectureStatus());
            Lucas.Join(Lecture1);
            Console.WriteLine("Is Student Lucas currentlly in a lecture (after joining): "
                + Lucas.getLectureStatus());
            Console.WriteLine("");
            Console.WriteLine("Name of lecture that Student Lucas is currently a part of: "
                + Lucas.getLecture().getName());
            Console.WriteLine("Amount of students online in Lucas' current lecture: "
                + Lucas.getLecture().getNumOfStudentsOnline());
            Console.WriteLine("");
            Console.WriteLine("");
            Lucas.Join(Lecture2);
            Console.WriteLine("Name of lecture that Student Lucas is currently in after"
                + "trying to join Lecture2: " + Lucas.getLecture().getName());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Speaker Boris will now begin Lecture1: ");
            Console.WriteLine("Is Speaker Boris currently in a Lecture: "+Boris.getLectureStatus());
            Boris.BeginLecture(Lecture1);
            Console.WriteLine("Is Speaker Boris in a lecture after starting Lecture1: "
                + Boris.getLectureStatus());
            Console.WriteLine("");
            Console.WriteLine("Name of lecture that Speaker Boris is currently a part of: "
                + Boris.getLecture().getName());
            Boris.ChangeLectureName(Lecture1, "Interaktionsdesign");
            Console.WriteLine("Name of Lecture1 after Speaker Boris has changed the name: "
                + Boris.getLecture().getName());
            Console.WriteLine("");
            Console.WriteLine("");
            Marcus.Join(Lecture1);
            Console.WriteLine("Amount of Students in Lecture1 after Student Marcus has joined: "
                + Lecture1.getNumOfStudentsOnline());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Amount of Students in Lecture2 before Student Sebastian joins: "
                + Lecture2.getNumOfStudentsOnline());
            Sebastian.Join(Lecture2);
            Console.WriteLine("Amount of Students online in Lecture2 after Student Sebastian"
                + "has joined: " + Lecture2.getNumOfStudentsOnline());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Student Lucas' information: " + Lucas.getInformation());
            Lucas.Listen();
            Console.WriteLine("Student Lucas' information after listening: "
                + Lucas.getInformation());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("This concludes that my program does as intented.");
            Console.WriteLine("1x 4 points plz :)");
        }
    }
}
