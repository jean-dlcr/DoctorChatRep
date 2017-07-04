using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorChatv5
{
    public class Doctor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string telef { get; set; }
        public string foto { get; set; }
        public string espe { get; set; }
        public string address { get; set; }
        public string descrip { get; set; }
        
        public Doctor(int id, string nombre, string apellidos, string email, string telef, string foto, string espe, string address, string descrip)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.telef = telef;
            this.foto = foto;
            this.espe = espe;
            this.address = address;
            this.descrip = descrip;
        }
        


    }
}