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
            /*for (int i = 0; i < studentList.Count; i++)
            {
                Student student = studentList[i];
                if (student.GetName() == name)
                    return true;
            }
            return false;*/
            return GetStudentIndex(name) != -1;//uso esta para hacer referencia a la otra función que he creado
        }
        //funcion que devuelva la posicion de un alumno dado un nombre. Devuelve un int
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
    //COUNT SIRVE PARA decirle que acceda  atodos los elementos que tiene esa lista
    //lucia != LUCIA  //PARA CONVERTIR EN MAYUSCULAS USO: ToUpper() así da igual si me has escrito lucia en mayusculas o minusculas = systima case sensitive
}
