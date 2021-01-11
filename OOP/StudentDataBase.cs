using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class StudentDataBase
    {
        private List<Student> studentList; //clase = studentList
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
            /*for (int i = 0; i < studentList.Count; i++)
            {
                Student student = studentList[i];
                if (student.GetName() == name)
                    return true;
            }
            return false;*/
            return GetStudentIndex(name) != -1;
        }
        //funcion que devuelve la posicion de un alumno dado un nombre.
        public int GetStudentIndex(string name) //GetStudentIndex es un método de objeto en toupper(mayuasculas)
        {
            if (name == null)
                return -1;
            for(int i=0;i< studentList.Count;i++)
            {
                Student s = studentList[i];
                if (s.GetName()!=null && s.GetName().ToUpper() == name.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
        public int GetStudentWithNia(int nia)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                Student s = studentList[i];
                if (s.GetNia() == nia)
                {
                    return i;
                }
            }
            return -1;
        }
        //quitar un estudiante 
        public void RemoveStudent(string name)
        {
            int index = GetStudentIndex(name); //devuelve -1
            if(index >= 0)
                studentList.RemoveAt(index);
        }
        public void RemoveStudent(int nia)
        {
            int index = GetStudentWithNia(nia);
            if (index >= 0)
                studentList.RemoveAt(index);
        }
    }
}
/*
    -->Count se utiliza para que acceda a todos los elementos que tiene esa lista de Student.
    -->Los enteros no pueden ser null
 */
