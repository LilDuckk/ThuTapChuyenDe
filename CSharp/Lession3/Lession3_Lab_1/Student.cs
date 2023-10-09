﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession3
{
    internal class Student
    {
        //khai báo lớp
        //khai báo trường private
        private int id;
        private string name;
        private string phoneNumber;
        private string email;

        //khai báo thuộc tính
        //Constructor
        public Student()
        {
        }
        public Student(int id, string name, string phoneNumber, string email)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        //khai báo đọc ghi

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //Phương pháp public biến

        /*public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }*/

    }
}
