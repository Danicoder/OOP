using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class StudentDataBase
    {
        private List<Student> studentList;//en vez de list puedeser studentlist
        //la clase se llama list

        public void Add(Student Student)
        {
            studentList.Add(Student);
        }

        public StudentDataBase()
        {
            studentList = new List<Student>();
        }

        public bool ContainsStudent(string name)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Student student = studentList[i];
                if (student.GetName() == name)
                    return true;
            }
            return false;
        }
        //funcion que devuelva la posicion de un alumno dado un nombre. Devuelve un int
        public int GetStudentIndex(string name)
        {
            for(int i=0;i< studentList.Count;i++)
            {
                Student s = studentList[i];

                if (s.GetName() == name)
                    return i;
            }
            return -1;
        }
    }
}
