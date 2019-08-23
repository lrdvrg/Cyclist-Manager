using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

 [Serializable]
public class ciclista {

    public string cedula;
    public string nombre;
    public string apellido;
    public string dia;
    public string mes;
    public string ano;
    public string sangre;
    public string sizeB;
    public string sizeU;
    public string telefono;
    public string celular;
    public string email;
    public string direccion;
    public string contacto;
    public string tContacto;
}

 [Serializable]
public class manejadorCiclista {
    private List<ciclista> todos = new List<ciclista>();

    public void agregarCiclista (ciclista cic) {
        todos.Add(cic);
    }

    public void borrarCiclista (int num) {
        todos.RemoveAt(num);
    }

    public int total () {
        return todos.Count;  
    }

    public List<ciclista> obtenerCiclista(){
        return todos;
    }
}