﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IStudentBL
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
        Task<int> AddNewStudent(Student student);
        Task<List<Student>> GetStudentByFamilyId(int familyId);
    }
}