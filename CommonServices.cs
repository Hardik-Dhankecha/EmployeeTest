using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTest.Models
{
    public class CommonServices
    {
        public List<City> cityList()
        {
            List<City> cityList = new List<City>();
            using (EmployeeTestEntities db = new EmployeeTestEntities())
            {
                cityList = db.Cities.ToList();
            }
            return cityList;
        }

        public List<State> stateList()
        {
            List<State> stateList = new List<State>();
            using (EmployeeTestEntities db = new EmployeeTestEntities())
            {
                stateList = db.States.ToList();
            }
            return stateList;
        }

        public List<Department> departmentList()
        {
            List<Department> departmentList = new List<Department>();
            using (EmployeeTestEntities db = new EmployeeTestEntities())
            {
                departmentList = db.Departments.ToList();
            }
            return departmentList;
        }

        public List<Employee> employeeList()
        {
            List<Employee> employeeList = new List<Employee>();
            using (EmployeeTestEntities db = new EmployeeTestEntities())
            {
                employeeList = db.Employees.ToList();
            }
            return employeeList;
        }

        public void SaveEmployee(CustomEmployee model)
        {
            Employee emp = new Employee();
            using (EmployeeTestEntities db = new EmployeeTestEntities())
            {
                emp.FirstName = model.FirstName;
                emp.LastName = model.LastName;
                emp.BirthDate = model.BirthDate;
                emp.Gender = model.Gender;
                emp.Salary = model.Salary;
                emp.FkCityId = model.FkCityId;
                emp.FkStateId = model.FkStateId;
                emp.FkDepartmentId = model.FkDepartmentId;
                emp.IsActive = model.IsActive;
                emp.Photo = "~/Images/" + model.user_image.FileName;

                db.Employees.Add(emp);
                db.SaveChanges();
            }
        }

        public Employee EmployeeById(int employeeId)
        {
            Employee employee = new Employee();
            using (EmployeeTestEntities db = new EmployeeTestEntities())
            {
                employee = db.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
            }
            return employee;
        }

        public void EditEmployee(CustomEmployee model)
        {
            Employee emp = new Employee();
            using (EmployeeTestEntities db = new EmployeeTestEntities())
            {
                emp = db.Employees.Where(x => x.EmployeeId == model.EmployeeId).FirstOrDefault();

                emp.FirstName = model.FirstName;
                emp.LastName = model.LastName;
                emp.BirthDate = model.BirthDate;
                emp.Gender = model.Gender;
                emp.Salary = model.Salary;
                emp.FkCityId = model.FkCityId;
                emp.FkStateId = model.FkStateId;
                emp.FkDepartmentId = model.FkDepartmentId;
                emp.IsActive = model.IsActive;
                emp.Photo = "~/Images/" + model.user_image.FileName;

                db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            Employee emp = new Employee();
            using (EmployeeTestEntities db = new EmployeeTestEntities())
            {
                emp = db.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
                db.Employees.Remove(emp);
                db.SaveChanges();
            }
        }
    }
}
