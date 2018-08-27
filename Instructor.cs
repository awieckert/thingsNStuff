// 1. private fields for first name and last name
// 2. Public calculated property that returns "Firstname Lastname" of instructor
// 3. Constructor that accepts first name and last name

using System;

namespace thingsNStuff
{
  public class Instructor
  {
    private string _firstName;
    private string _lastName;

    public string FullName {get => $"{this._firstName} {this._lastName}";}

    public Instructor(string firstName, string lastName) {
      _firstName = firstName;
      _lastName = lastName;
    }

//     1. Create some exercises
// 2. Write a method on the `Instructor` class that will allow you to assign an individual exercise to an individual student

    public void addExercise (Student student, Exercise exercise, Cohort cohort) {
      bool isInstructor = false;
      bool isStudent = false;
      foreach (Instructor instructor in cohort.Instructors)
      {
        if (instructor.FullName == this.FullName) {
          isInstructor = true;
          break;
        }
      }

      foreach (Student person in cohort.Students)
      {
        if (person.FullName == student.FullName) {
          isStudent = true;
          break;
        }
      }

      if (isInstructor && isStudent) {
        student.Exercises.Add(exercise);
      }

    }
  }
}