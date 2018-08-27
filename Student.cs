// 1. private fields for first name and last name
// 2. Public calculated property that returns "Firstname Lastname" of student
// 3. Constructor that accepts first name and last name
// 4. A public list of exercises

using System;
using System.Collections.Generic;

namespace thingsNStuff
{
  public class Student
  {
    private string _firstName;
    private string _lastName;

    public string FullName {get => $"{this._firstName} {this._lastName}";}

    public List<Exercise> Exercises {get;} = new List<Exercise>();

    public Student(string firstname, string lastname) {
      _firstName = firstname;
      _lastName = lastname;
    }
  }
}