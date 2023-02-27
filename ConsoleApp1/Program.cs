using ConsoleApp1;

var students = new List<Student>();
var majors = new List<Major>();
majors.Add(new Major("CNTT", "Computer Science"));
majors.Add(new Major("KTCN", "Software engineer"));


int choice;
do
{
    Console.WriteLine("Student Manage Application : ");
    Console.WriteLine("1.Add student. ");
    Console.WriteLine("2.Edit student. ");
    Console.WriteLine("3.Delete student. ");
    Console.WriteLine("4.Display student board. ");
    Console.WriteLine("Enter your choice:");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddStudent(students);
            break;
        case 2:
            EditStudent(students);
            break;
        case 4:
            DisplayStudents(students);
            break;

        case 0:
            Console.WriteLine("Exit.");
            break;
        default:
            Console.WriteLine("Choice invalid please try again.");
            break;
    }

} while (choice != 0);
void AddStudent(List<Student> students)
{
    var student = new Student();
    Console.WriteLine("Enter student id:");
    var id = Console.ReadLine();
    Console.WriteLine("Enter student name:");
    var name = Console.ReadLine();
    Console.WriteLine("Enter date of birth:");
    var dateOfBirth = Console.ReadLine();
    Console.WriteLine("Enter student gender:");
    var gender = Console.ReadLine();
    Console.WriteLine("Enter major id of student:");
    var majorId = Console.ReadLine();

    foreach (var major in majors)
    {
        if (major.MajorId == majorId)
        {
            student.Major = major;
            break;
        }
    }
    if (student.Major == null)
    {
        Console.WriteLine("Enter major name:");
        var majorName = Console.ReadLine();
        student.Major = new Major(majorId, majorName);
    }
    student.Id = id;
    student.Name = name;
    student.DateOfBirthSaving = DateTime.Parse(dateOfBirth);
    student.Gender = gender;
    student.MajorId = majorId;
    students.Add(student);
    Console.WriteLine("Add student successfully");


}
void EditStudent(List<Student> students)
{
    Console.WriteLine("Nhập mã sinh viên bạn muốn sửa: ");
    var id = Console.ReadLine();

    foreach (var student in students)
    {
        if (student.Id == id)
        {
            Console.WriteLine("Enter student name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter date of birth:");
            var dateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter student gender:");
            var gender = Console.ReadLine();
            Console.WriteLine("Enter major id of student:");
            var majorId = Console.ReadLine();
            student.Id = id;

            student.Name = name;
            student.DateOfBirthSaving = DateTime.Parse(dateOfBirth);
            student.Gender = gender;
            student.MajorId = majorId;

        }
    }
}
void DisplayStudents(List<Student> students)
{

    Console.WriteLine("Thông tin sinh viên:");
    Console.WriteLine("| {0,-10} | {1,-20} | {2,-15} | {3,-10} | {4,-25}", "Id", "Name", "Date of Birth", "Gender", "Khoa");

    foreach (var student in students)
    {

        Console.WriteLine("| {0,-10} | {1,-20} | {2,-15} | {3,-10} | {4,-25}", student.Id, student.Name, student.DateOfBirthSaving.Day, student.Gender, student.Major.MajorName);
    }
}
