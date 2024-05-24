using OOP_University_Management.University_Management;

University university = new University { Name = "My University" };

Department csDept = new Department { DeptNo = 1, Name = "Computer Science", Description = "Department of Computer Science" };
Console.WriteLine(university.AddDepartment(csDept));

Department eeDept = new Department { DeptNo = 2, Name = "Electrical Engineering", Description = "Department of Electrical Engineering" };
Console.WriteLine(university.AddDepartment(eeDept));

Console.WriteLine(csDept.AddStudent(new Student { RegNo = 101, Name = "Atik Hassan" }));

Console.WriteLine(csDept.AddStudent(new Student { RegNo = 102, Name = "Mehedi Hassan" }));

Console.WriteLine(eeDept.AddStudent(new Student { RegNo = 201, Name = "Ashib Hassan" }));

Console.WriteLine(university.UpdateDepartment(1, "CS", "Department of CS"));

Console.WriteLine(university.RemoveDepartment(2));

Console.WriteLine("\nDepartments and their Students:");
foreach (var dept in university.GetAllDepartments())
{
    Console.WriteLine($"\nDepartment: {dept.Name} ({dept.DeptNo}) - {dept.Description}");
    Console.WriteLine("Sl. RegNo. Name");
    int serial = 1;
    foreach (var student in dept.GetAllStudents())
    {
        Console.WriteLine($"{serial}. {student.RegNo} {student.Name}");
        serial++;
    }
}

Console.WriteLine($"\nTotal Students in CS Department: {csDept.TotalStudents()}");