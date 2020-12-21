using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Student
    {
        //propieedades de los objetos no llevan static
        //public string son atributos no funciones

        private string name;
        private int nia;
        //función para poder poner el valor name al valor que yo quiera dejando lo de private
        public void SetNia(int value)
        {
            //el objeto nia es el estudiante de la referencia (st)
            nia = value;
        }
        public void SetName(string value)
        {
            name = value.ToUpper();
            //En el caso de repetir el mismo nombre para nombrar la variable y la refernecia; debo usar this.(referencia)name=name(valor de la función)
            //en ese caso al compilar lera name=name (ambos valores), hará una copia de la referencia de ese objeto
            //ToUpper(); para que los objetos tengan la variable en mayusculas
            /*Siempre que sea set. algo. se llaman seters, lo contrario getters: para que desde otro sitio accedan y sepan mi NIA*/
        }
        public void SetName2(string name)
        {
            this.name = name;
        }

        //toda funcion o metodo que tenga un set se denomina "setter"

        //ahora vamos las funciones o metodos que tengan get y se denominara "getter"
        public int GetNia()
        {
            return nia; 
            
        }
        public string GetName()
        {
            return name;
        }
        public Student(string name, int nia)
        {
            this.name = name;
            this.nia = nia;
        }
        //esto es onstructor//
        public Student()
        {

        }

    }
}
