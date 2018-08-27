using System;

namespace thingsNStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student adam = new Student("Adam", "Wieckert");
            Student seth = new Student("Seth", "Dana");
            Student emily = new Student("Emily", "Westbrook");
            Student notIn26 = new Student("MrMan", "TheMan");

            Instructor steve = new Instructor("Steve", "Coach");
            Instructor zoe = new Instructor("Zoe", "Ames");
            Instructor callan = new Instructor("Callan", "Morrison");

            Exercise ex1 = new Exercise();
            ex1.Name = "ChickenMonkey";
            ex1.Language = "JavaScript";
            ex1.GitHubUrl = "www.github.com";

            Exercise ex2 = new Exercise();
            ex1.Name = "KillHanson";
            ex1.Language = "C#";
            ex1.GitHubUrl = "www.github.com";

            Exercise ex3 = new Exercise(){
              Name = "KillNickleBack",
              Language = "C++",
              GitHubUrl = "www.github.com"
            };

            Cohort cohort26 = new Cohort();

            // List<Student> listOStudents = new List<Student>();

            cohort26.addStudent(adam);
            cohort26.addStudent(seth);
            cohort26.addStudent(emily);

            cohort26.addInstructor(steve);
            cohort26.addInstructor(zoe);
            cohort26.addInstructor(callan);
            zoe.addExercise(emily, ex1, cohort26);
            zoe.addExercise(notIn26, ex2, cohort26);

            foreach (Exercise exercise in emily.Exercises)
            {
                Console.WriteLine($"{exercise.Name}");
            }

            foreach (Exercise exercise in notIn26.Exercises)
            {
                Console.WriteLine($"{exercise.Name}");
            }

        }
    }
}
