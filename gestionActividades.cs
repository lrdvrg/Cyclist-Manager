using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

 [Serializable]
public class actividad {

    public string cedula;
    public string nombre;
    public string apellido;
    public string telefono;
    public string dificultad;
    public string fecha;
    public string distancia;
    public string lugar;

}

 [Serializable]
public class manejadorActividad {
    private List<actividad> todos2 = new List<actividad>();

    public void agregarActividad (actividad act) {
        todos2.Add(act);
    }

    public void borrarActividad (int num) {
        todos2.RemoveAt(num);
    }


    public int total () {
        return todos2.Count;  
    }

    public List<actividad> obtenerActividad(){
        return todos2;
    }
}