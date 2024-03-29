﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;

namespace _81.Bussiness_Object.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBussinessLayer employeeBusinessLayer =
            new EmployeeBussinessLayer();

            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBussinessLayer employeeBusinessLayer =
                   new EmployeeBussinessLayer();
            Employee employee =
                   employeeBusinessLayer.Employees.Single(emp => emp.ID == id);

            return View(employee);
        }


        //20 Video (UpdateModel)
        /*[HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            EmployeeBussinessLayer employeeBusinessLayer = new EmployeeBussinessLayer();

            Employee employee = employeeBusinessLayer.Employees.Single(x => x.ID == id);
            UpdateModel(employee, new string[] { "ID", "Gender", "City", "DateOfBirth" });

            if (ModelState.IsValid)
            {
                employeeBusinessLayer.SaveEmployee(employee);

                return RedirectToAction("Index");
            }

            return View(employee);
        }*/







        //21 Video (Bind Attribute)

        /*[HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post([Bind(Include = "Id, Gender, City, DateOfBirth")] Employee employee)
        {
            EmployeeBussinessLayer employeeBusinessLayer = new EmployeeBussinessLayer();
            employee.Name = employeeBusinessLayer.Employees.Single(x => x.ID == employee.ID).Name;

            if (ModelState.IsValid)
            {
                employeeBusinessLayer.SaveEmployee(employee);

                return RedirectToAction("Index");
            }

            return View(employee);
        }*/


        //22 Video (Interfaces)
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            EmployeeBussinessLayer employeeBusinessLayer = new EmployeeBussinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(x => x.ID == id);
            UpdateModel<IEmployee>(employee);

            if (ModelState.IsValid)
            {
                employeeBusinessLayer.SaveEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            if (ModelState.IsValid)
            {
                EmployeeBussinessLayer employeeBusinessLayer =
                    new EmployeeBussinessLayer();

                Employee employee = new Employee();
                UpdateModel<Employee>(employee);

                employeeBusinessLayer.AddEmmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}