using Grading_the_students;

Console.WriteLine("creo 10 studenti con nomi e voto");
Student students = new();

Student student1 = new Student("Marco", 26);
Student student2 = new Student("Luca", 30);
Student student3 = new Student("Anna", 28);
Student student4 = new Student("GianMarco", 19);
Student student5 = new Student("Franco", 21);
Student student6 = new Student("Lucia", 20);
Student student7 = new Student("Alice", 26);
Student student8 = new Student("Francesca", 29);
Student student9 = new Student("Emanuele", 23);
Student student10 = new Student("Mario", 22);

List<Student> StudentList = new()
{
    student1, student2, student3, student4, student5,
    student6, student7, student8, student9, student10,
};

foreach(Student name in StudentList)
{
    Console.WriteLine(name.GetStudent());
}

double totalGrade = 0.0;

foreach (Student student in studentList)
{
    totalGrade += student.GradeStudent;
}
double averangeGrade = totalGrade / studentList.Count;

Console.WriteLine("\nla media totale è " + averangeGrade);

Console.Write("\nlo/a studente/ssa con il voto più alto è: ");

string NameStudent = students.GetNameStudentWithGradeMax(StudentList);
Console.WriteLine("nome: " + NameStudent);
