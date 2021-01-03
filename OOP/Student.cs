using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Student
    {
        private string name;
        private int nia;
        
        public void SetNia(int value)
        {
            nia = value;
        }
        public void SetName(string value)
        {
            name = value.ToUpper(); 
        }
        public void SetName2(string name)
        {
            this.name = name;
        }
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
            this.name = name; //name(atributo de la clase)=name(valor de la función)
            this.nia = nia;
        }
        public Student()
        {

        }
    }
}
/*
    -->Se usa private al principio para poner al valor establecido cualquier valor.
    -->Para evitar que se repita una referencia o un valor debo usar this.(referencia).
    -->Para que los objetos tengan la variable en mayusculas ToUpper(). lucia != LUCIA.Mayusculas o minusculas = systima case sensitive
    -->El constructor es: public Student()
    -->Toda funcion o metodo que tenga un set se denomina "SETTERS".Lo contrario, GETERS: para que desde otro sitio accedan
 */
