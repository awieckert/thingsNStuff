// 1. Maintains a list of students
// 2. Maintains a list of instructors
// 3. Has a property of the cohort number

using System;
using System.Collections.Generic;

namespace thingsNStuff
{
  public class Cohort
  {
    public string CohortNumber {get;}
    public List<Student> Students {get; set;} = new List<Student>();
    public List<Instructor> Instructors {get; set;} = new List<Instructor>();


    public Cohort(){}
    public Cohort(List<Student> students, List<Instructor> instructors) {
      Students = students;
      Instructors = instructors;
    }

    public void addStudent (Student student) {
      this.Students.Add(student);
    }

    public void addInstructor (Instructor instructor) {
      this.Instructors.Add(instructor);
    }
  }
}