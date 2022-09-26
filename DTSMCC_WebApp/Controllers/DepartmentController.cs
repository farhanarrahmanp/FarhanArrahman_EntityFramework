using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using DTSMCC_WebApp.Models;
using DTSMCC_WebApp.Context;
using DTSMCC_WebApp.ViewModels;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DTSMCC_WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        MyContext myContext;

        public DepartmentController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        //SqlConnection sqlConnection;

        //string connectionString = "Data Source=localhost;Initial Catalog=DTSMCC01;" +
        //    "User Id=sa;Password=SQL Server 2017;";

        // READ
        // GET: /<controller>/

        public IActionResult Index()
        {
            //string query = "SELECT Department.Id, Department.Name, Division.Name FROM Department join Division on Department.DivisionId = Division.Id";

            //sqlConnection = new SqlConnection(connectionString);
            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //List<Department> Departments = new List<Department>();

            //try
            //{
            //    sqlConnection.Open();
            //    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            //    {
            //        if (sqlDataReader.HasRows)
            //        {
            //            while (sqlDataReader.Read())
            //            {
            //                Department department = new Department();
            //                department.Id = Convert.ToInt32(sqlDataReader[0]);
            //                department.Name = sqlDataReader[1].ToString();
            //                department.DivisionName = sqlDataReader[2].ToString();
            //                Departments.Add(department);
            //            }
            //        }
            //        sqlDataReader.Close();
            //    }
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.InnerException);
            //}
            //return View(Departments);

            var data = myContext.Departments.Include(x => x.Division).ToList(); // Join
            Console.WriteLine(data);
            return View(data);
        }

        // CREATE
        // GET
        public IActionResult Create()
        {
            CreateViewModel createViewModel = new CreateViewModel();
            createViewModel.Departments = myContext.Departments.ToList();
            createViewModel.Divisions = myContext.Divisions.ToList();
            Console.WriteLine(createViewModel.Departments);
            Console.WriteLine(createViewModel.Divisions);
            return View(createViewModel);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                //myContext.Departments.Add/Remove/Update(department);
                myContext.Departments.Add(department);
                var result = myContext.SaveChanges(); // return int 1 = eksekusi, 0 = tidak tereksekusi
                if(result > 0)
                {
                    return RedirectToAction("Index");
                }
                // row yang tereksekusi = executenonquery
            }
            return View();
        }

        // UPDATE
        // GET
        public IActionResult Update(int id)
        {
            var data = myContext.Departments.Single(x => x.Id == id);
            return View(data);
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Department department)
        {
            if (ModelState.IsValid)
            {
                //myContext.Departments.Add/Remove/Update(department);
                myContext.Departments.Update(department);
                var result = myContext.SaveChanges(); // return int 1 = eksekusi, 0 = tidak tereksekusi
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                // row yang tereksekusi = executenonquery
            }
            return View();
        }

        // DELETE
        // GET
        public IActionResult Delete(int id)
        {
            var data = myContext.Departments.Single(x => x.Id == id);
            return View(data);
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Department department)
        {
            if (ModelState.IsValid)
            {
                //myContext.Departments.Add/Remove/Update(department);
                myContext.Departments.Remove(department);
                var result = myContext.SaveChanges(); // return int 1 = eksekusi, 0 = tidak tereksekusi
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                // row yang tereksekusi = executenonquery
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { });
        }
    }
}
