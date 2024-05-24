using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_University_Management.University_Management
{
    public class University
    {
        public string Name { get; set; }
        private List<Department> departments = new List<Department>();

        public string AddDepartment(Department department)
        {
            string message = "";
            if (departments.Exists(d => d.DeptNo == department.DeptNo))
            {
                message = "A department with the same DeptNo already exists.";
                return message;
            }
            departments.Add(department);
            message = "Department added successfully.";
            return message;
        }

        public string RemoveDepartment(int deptNo)
        {
            string message = "";
            Department department = departments.Find(d => d.DeptNo == deptNo);
            if (department != null)
            {
                departments.Remove(department);
                message = "Department removed successfully.";
                return message;
            }
            message = "Department not found.";
            return message;
        }

        public string UpdateDepartment(int deptNo, string newName, string newDescription)
        {
            string message = "";
            Department department = departments.Find(d => d.DeptNo == deptNo);
            if (department != null)
            {
                department.Name = newName;
                department.Description = newDescription;
                message = "Department updated successfully.";
                return message;
            }
            message = "Department not found.";
            return message;
        }

        public Department GetDepartmentByDeptNo(int deptNo)
        {
            return departments.Find(d => d.DeptNo == deptNo);
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }
    }
}
