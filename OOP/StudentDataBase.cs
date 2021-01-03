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
        public int GetStudentIndex(string name) //GetStudentIndex es un método de objeto = toupper
        {
            for(int i=0;i< studentList.Count;i++)
            {
                Student s = studentList[i];
                if (s.GetName()!=null && s.GetName().ToUpper() == name)
                {
                    for (int j = 0; j < studentList.Count; j++)
                    {
                        if (s.GetName().ToUpper() == name.ToUpper())
                            return j;
                    }
                }
            }
            return -1;
        }
    }
}
/*
    -->Count se utiliza para que acceda a todos los elementos que tiene esa lista de Student.
 */
