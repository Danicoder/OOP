using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //<de que tipo esta creada la lista>
            //es una referencia que se guarda en la RAM y new Object es una funcion creada en esa referencia (flecha)
            //st es una referencia, una "flecha" hacia el objeto creado

            //List<Student> list = new List<Student>();
            Student st = new Student();
            Student s2 = st;
            Student st2 = new Student();
            StudentDataBase db = new StudentDataBase();
            db.Add(st);
            Student s3 = new Student("Oscar", 3);
            
            /*st.nia = 7;
            s2.name = "Óscar;";
            st2.nia = 3;
            st2.name = "Ana";*/

            st.SetNia(7);
            st2.SetNia(3);

            st.SetName2("Pepe");
            st2.SetName2("Elena");

            /*System.Console.WriteLine("El nia de " + st.GetName() + " es " +  st.GetNia());
            System.Console.WriteLine("El nia de " + st2.GetName() + " es " + st2.GetNia());*/

            //las listas son listas de referencias a objetos, no de objetos en si, por lo que si añadimos las
            //referencias a la lista y luego cambiamos las propiedades estas cambiaran
            db.Add(st);
            db.Add(st2);
            //list.Add(null); para forzar un error 
            bool test = db.ContainsStudent("Paco");
        }
        //static: nombre... si no objeto.static
        /*IMPORTANTE: Sysbolizar una lista donde no hay nada (phi)*/
    }
}
