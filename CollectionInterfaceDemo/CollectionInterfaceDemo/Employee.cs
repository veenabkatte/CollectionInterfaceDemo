﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionInterfaceDemo
{
    class Employees : IEnumerable<Employee>, IDisposable
    {
        List<Employee> employeeList = new List<Employee>();

        //  Indexer property
        public Employee this[int index]
        {
            get
            {
                return employeeList[index];
            }
            set
            {
                employeeList.Add(value);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return employeeList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
    }
}


