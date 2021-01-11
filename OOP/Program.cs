using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Student st = new Student();
            Student s2 = st;
            Student st2 = new Student();
            StudentDataBase db = new StudentDataBase();
            //Student s3 = new Student("Oscar", 3);
            
            st.SetNia(7);
            st2.SetNia(3);
            st.SetName2("Paco"); //debería devolver -1, como no lo hace, hacer que devuelva dicho valor
            st2.SetName2("Elena");

                        db.Add(st);
                        db.Add(st2);
                        db.RemoveStudent("Paco");
                        db.RemoveStudent(3);
            /*bool test = db.ContainsStudent("Paco");
            int test2 = db.GetStudentIndex("Lucia");//devuelve -1
            int test3 = db.GetStudentIndex("Juan");//devuelve -1
            int test4 = db.GetStudentIndex("LUCIA");//devuelve -1
            int test5 = db.GetStudentIndex("Oscar");//devuelve -1
            int test6 = db.GetStudentIndex("Elena"); //devuelve -1*/
        }
    }
    /*
     --> Student es una referencia que se guarda en la RAM y new = object es una funcion creada en esa referencia
     st es una referencia de Student:

     System.Console.WriteLine("El nia de " + st.GetName() + " es " +  st.GetNia());
     System.Console.WriteLine("El nia de " + st2.GetName() + " es " + st2.GetNia());

     --> Las listas son listas de referencias a objetos, no de objetos en si, por lo que si añadimos las
     referencias a la lista y luego cambiamos las propiedades estas cambiaran:

     List<Student> list = new List<Student>();
     <de que tipo esta creada la lista>
     list.Add(null); para forzar un error
     IMPORTANTE: Sysbolizar una lista donde no hay nada (phi)
    
     -->Public ____ son atributos (sin static: propiedades de los objetos)
    -->Si ambos atributos se poenen como null, entonces devuelve 0 y error: comunica que ha cambiado, cuando stName = null también
    
     */
}
