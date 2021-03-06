﻿using System.Collections;

namespace Sistema_Empenos_Anderson
{
    public class Usuario
    {
        private string Nombre_Usuario, Password_Usuario, Tipo_Usuario, Pregunta1, Pregunta2, Respuesta1, Respuesta2;
        private int Codigo_Tipo_Usuario, Codigo_Usuario, Estado;

        public Usuario()
        {
        }

        public Usuario(string nombre_Usuario, string password_Usuario, string tipo_Usuario, int codigo_Tipo_Usuario, int codigo_Usuario)
        {
            Nombre_Usuario = nombre_Usuario;
            Password_Usuario = password_Usuario;
            Tipo_Usuario = tipo_Usuario;
            Codigo_Tipo_Usuario = codigo_Tipo_Usuario;
            Codigo_Usuario = codigo_Usuario;
        }

        public string nombre_Usuario
        {
            get { return this.Nombre_Usuario; }
            set { this.Nombre_Usuario = value; }
        }

        public string password_Usuario
        {
            get { return this.Password_Usuario; }
            set { this.Password_Usuario = value; }
        }

        public string tipo_Usuario
        {
            get { return this.Tipo_Usuario; }
            set { this.Tipo_Usuario = value; }
        }

        public int codigo_Tipo_Usuario
        {
            get { return this.Codigo_Tipo_Usuario; }
            set { this.Codigo_Tipo_Usuario = value; }
        }

        public int codigo_Usuario
        {
            get { return this.Codigo_Usuario; }
            set { this.Codigo_Usuario = value; }
        }

        public string pregunta1
        {
            get { return this.Pregunta1; }
            set { this.Pregunta1 = value; }
        }

        public string pregunta2
        {
            get { return this.Pregunta2; }
            set { this.Pregunta2 = value; }
        }

        public string respuesta1
        {
            get { return this.Respuesta1; }
            set { this.Respuesta1 = value; }
        }

        public string respuesta2
        {
            get { return this.Respuesta2; }
            set { this.Respuesta2 = value; }
        }

        public int estado
        {
            get { return this.Estado; }
            set { this.Estado = value; }
        }
    }
}
