using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class programa {
    
    public static void Main(String [] args){

        manejadorCiclista mngCic = new manejadorCiclista();
        manejadorActividad mngAct = new manejadorActividad();

        bool continuar = true;
        string entrada = "";
        List<ciclista> todos = null;
        List<actividad> todos2 = null;

        FileStream streamRead = new FileStream("data.dat",FileMode.Open);
        BinaryFormatter formaterRead = new BinaryFormatter();
        mngCic = (manejadorCiclista) (formaterRead.Deserialize(streamRead));
        streamRead.Close();

        FileStream streamRead2 = new FileStream("data2.dat",FileMode.Open);
        BinaryFormatter formaterRead2 = new BinaryFormatter();
        mngAct = (manejadorActividad) (formaterRead2.Deserialize(streamRead2));
        streamRead2.Close();

        while(continuar){

            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║PROGRAMA DE GESTION DE CICLISTAS                                    (Existen "+mngCic.total()+" personas y "+mngAct.total()+ " actividades)    ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("                                     -+88_");
            Console.WriteLine("                                     _+880_");
            Console.WriteLine("                                     _++88_");
            Console.WriteLine("                                     _++88_");
            Console.WriteLine("                                     __+880_________________________++_");
            Console.WriteLine("                                     __+888________________________+88_");
            Console.WriteLine("                                     __++880______________________+88_");
            Console.WriteLine("                                     __++888_____+++88__________+++8_");
            Console.WriteLine("                                     __++8888__+++8880++88____+++88_");
            Console.WriteLine("╔═══════════════════════════════════╗__+++8888+++8880++8888__++888_                   ╔══════════════════════╗");
            Console.WriteLine("║a- Registrar ciclista              ║___++888++8888+++888888++888_                    ║s- Salir del programa ║");
            Console.WriteLine("║b- Eliminar ciclista               ║___++88++8888++8888888++888_                     ╚══════════════════════╝");
            Console.WriteLine("║m- Modificar ciclista              ║___++++++888888888888888888_");
            Console.WriteLine("║v- Ver listado de ciclistas        ║____++++++88888888888888888_");
            Console.WriteLine("╚═══════════════════════════════════╝____++++++++000888888888888_");
            Console.WriteLine("╔═══════════════════════════════════╗_____+++++++000088888888888_");
            Console.WriteLine("║r- Registrar actividad             ║______+++++++00088888888888_");
            Console.WriteLine("║x- Eliminar actividad              ║_______+++++++088888888888_");
            Console.WriteLine("║c- Ver listado de actividades      ║_______+++++++088888888888_");
            Console.WriteLine("╚═══════════════════════════════════╝________+++++++8888888888_");
            Console.WriteLine("╔═══════════════════════════════════╗________+++++++0088888888_");
            Console.WriteLine("║z- Ver listado por signo zodiacal  ║________++++++0088888888_");            
            Console.WriteLine("║e- Exportar ciclista               ║________+++++0008888888_");
            Console.WriteLine("╚═══════════════════════════════════╝________#############_");
            Console.Write("Digite una opcion: ");
            entrada = Console.ReadLine();

            switch(entrada){
                case "a":
                    ciclista cic = new ciclista(); 
                    Console.Clear();
                    Console.WriteLine("Agregando datos del ciclista");

                    Console.WriteLine("Digite el nombre: ");
                    cic.nombre = Console.ReadLine();
                    Console.WriteLine("Digite el apellido: ");
                    cic.apellido = Console.ReadLine();
                    Console.WriteLine("Digite la cedula: ");
                    cic.cedula = Console.ReadLine();
                    Console.WriteLine("Digite el dia de nacimiento: ");
                    cic.dia = Console.ReadLine();
                    Console.WriteLine("Digite el mes de nacimiento: ");
                    cic.mes = Console.ReadLine();
                    Console.WriteLine("Digite el año de nacimiento: ");
                    cic.ano = Console.ReadLine();
                    Console.WriteLine("Digite el tipo de sangre: ");
                    cic.sangre = Console.ReadLine();
                    Console.WriteLine("Digite el size de bicicleta: ");
                    cic.sizeB = Console.ReadLine();
                    Console.WriteLine("Digite el size de uniforme: ");
                    cic.sizeU = Console.ReadLine();
                    Console.WriteLine("Digite el numero de telefono: ");
                    cic.telefono = Console.ReadLine();
                    Console.WriteLine("Digite el numero de celular: ");
                    cic.celular = Console.ReadLine();
                    Console.WriteLine("Digite el email: ");
                    cic.email = Console.ReadLine();
                    Console.WriteLine("Digite la direccion del ciclista: ");
                    cic.direccion = Console.ReadLine();
                    Console.WriteLine("Digite el contacto: ");
                    cic.contacto = Console.ReadLine();
                    Console.WriteLine("Digite el telefono del contacto: ");
                    cic.tContacto = Console.ReadLine();

                    mngCic.agregarCiclista(cic);
                break;

                case "m":
                    Console.Clear();

                    if(mngCic.total() > 0){

                    Console.WriteLine("Estos son los ciclistas agregados, digite el numero del que desea modificar: ");
                    todos = mngCic.obtenerCiclista();
                    int n = 1;
                    foreach(ciclista gente in todos){
                        Console.WriteLine("No: {13} - Nombre: {0} - Apellido: {1} Cedula: {2} - Fecha de nacimiento: {3}/{13}/{14} - Tipo de Sangre: {4} - Size de bicicleta : {5} - Size de uniforme: {6} - Telefono: {7} - Celular: {8} - Email: {9} - Direccion: {10} - Contacto: {11} - Telefono de contacto: {12}", gente.nombre, gente.apellido, gente.cedula, gente.dia, gente.sangre, gente.sizeB, gente.sizeU, gente.telefono, gente.celular, gente.email, gente.direccion, gente.contacto, gente.tContacto, n, gente.mes, gente.ano); 
                        Console.WriteLine();
                        n++;
                    }
                    Console.Write("Digite el numero a borrar: ");
                    int num = 0;
                    int.TryParse(Console.ReadLine(), out num);
                    if (num>0 && num < mngCic.total()+1){
                    mngCic.borrarCiclista(num-1);
                    Console.WriteLine("Presione cualquier tecla para ingresar los nuevos datos al ciclista.");
                    Console.ReadKey();
                    goto case "a";
                    } else {
                        Console.WriteLine("¡Hay un problema! El numero ingresado es incorrecto.");
                        Console.WriteLine();
                    }
                    } else {
                        Console.WriteLine("No hay ciclistas registrados en el sistema.");
                    }
                    Console.ReadKey();
                break;

                case "b":
                    Console.Clear();

                    if(mngCic.total() > 0){

                    Console.WriteLine("Estos son los ciclistas agregados, digite el numero del que desea borrar: ");
                    todos = mngCic.obtenerCiclista();
                    int n = 1;
                    foreach(ciclista gente in todos){
                        Console.WriteLine("No: {13} - Nombre: {0} - Apellido: {1} Cedula: {2} - Fecha de nacimiento: {3}/{13}/{14} - Tipo de Sangre: {4} - Size de bicicleta : {5} - Size de uniforme: {6} - Telefono: {7} - Celular: {8} - Email: {9} - Direccion: {10} - Contacto: {11} - Telefono de contacto: {12}", gente.nombre, gente.apellido, gente.cedula, gente.dia, gente.sangre, gente.sizeB, gente.sizeU, gente.telefono, gente.celular, gente.email, gente.direccion, gente.contacto, gente.tContacto, n, gente.mes, gente.ano);
                        Console.WriteLine(); 
                    n++;
                    }
                    Console.Write("Digite el numero del ciclista a borrar: ");
                    int num = 0;
                    int.TryParse(Console.ReadLine(), out num);
                    if (num>0 && num < mngCic.total()+1){
                    mngCic.borrarCiclista(num-1);
                    Console.WriteLine("¡Listo! El ciclista fue correctamente borrado.");
                    } else {
                        Console.WriteLine("¡Hay un problema! El numero ingresado es incorrecto.");
                    }
                    } else {
                        Console.WriteLine("No hay ciclistas registrados en el sistema.");
                    }
                    Console.ReadKey();
                break;

                case "v":
                    Console.Clear();
                    Console.WriteLine("Estos son los ciclistas agregados: ");
                    Console.WriteLine();
                    todos = mngCic.obtenerCiclista();
                    foreach(ciclista gente in todos){
                        Console.WriteLine("Nombre: {0} - Apellido: {1} Cedula: {2} - Fecha de nacimiento: {3}/{13}/{14} - Tipo de Sangre: {4} - Size de bicicleta : {5} - Size de uniforme: {6} - Telefono: {7} - Celular: {8} - Email: {9} - Direccion: {10} - Contacto: {11} - Telefono de contacto: {12}", gente.nombre, gente.apellido, gente.cedula, gente.dia, gente.sangre, gente.sizeB, gente.sizeU, gente.telefono, gente.celular, gente.email, gente.direccion, gente.contacto, gente.tContacto, gente.mes, gente.ano); 
                        Console.WriteLine();
                    }
                    Console.WriteLine("Para volver al menu principal, presione cualquier tecla.");
                    Console.ReadKey();
                break;

                case "r":
                    Console.Clear();
                    actividad act = new actividad(); 
                    todos = mngCic.obtenerCiclista();
                    todos2 = mngAct.obtenerActividad();
                    int m = 1;
                    foreach(ciclista gente in todos){
                        Console.WriteLine("No: {0} - Nombre: {1} - Apellido: {2} - Cedula: {3} - Telefono: {4} ", m, gente.nombre, gente.apellido, gente.cedula, gente.telefono);
                        Console.WriteLine(); 
                    m++;
                    }
                    Console.Write("Digite el numero del ciclista a registrar una actividad: ");
                    int num2 = 0;
                    int.TryParse(Console.ReadLine(), out num2);
                    if (mngCic.total() > 0){
                    if(num2>0 && num2<mngCic.total()+1){
                    Console.Write("Valide el ciclista con su cedula: ");
                    act.cedula = Console.ReadLine();
                    Console.WriteLine("Digite el lugar: ");
                    act.lugar = Console.ReadLine();
                    Console.WriteLine("Digite la fecha: (dd/mm/aaaa)");
                    act.fecha = Console.ReadLine();
                    Console.WriteLine("Digite la distancia (en km): ");
                    act.distancia = Console.ReadLine();
                    Console.WriteLine("Digite la dificultad (baja/media/alta): ");
                    act.dificultad = Console.ReadLine();
                    foreach(ciclista gente in todos){
                    if (act.cedula == gente.cedula){
                        act.nombre = gente.nombre;
                        act.apellido = gente.apellido;
                        act.telefono = gente.telefono;
                    }
                    }
                    Console.WriteLine("¡Listo! La actividad ha sido correctamente registrada.");
                    mngAct.agregarActividad(act);
                    } else {
                        Console.WriteLine("¡Hay un problema! El numero ingresado es incorrecto.");
                    }
                    } else {
                        Console.WriteLine("No hay ciclistas registrados en el sistema para poder registrar una actividad.");
                    }
                    Console.ReadKey();
                break;

                case "x":
                    Console.Clear();

                    if(mngCic.total() > 0){

                    Console.WriteLine("Estas son las actividades agregadas, digite el numero de la que desea borrar: ");
                    todos2 = mngAct.obtenerActividad();
                    int n = 1;
                    foreach(actividad gente in todos2){
                        Console.WriteLine("No: {0} - Lugar: {1} - Fecha: {2} - Dificultad: {5} - Realizada por: {3} {4} ", n, gente.lugar, gente.fecha, gente.nombre, gente.apellido, gente.dificultad);
                        Console.WriteLine(); 
                    n++;
                    }
                    Console.Write("Digite el numero de la actividad a borrar: ");
                    int num = 0;
                    int.TryParse(Console.ReadLine(), out num);
                    if (num>0 && num < mngAct.total()+1){
                    mngAct.borrarActividad(num-1);
                    Console.WriteLine("¡Listo! La actividad fue correctamente eliminada.");
                    } else {
                        Console.WriteLine("¡Hay un problema! El numero ingresado es incorrecto.");
                        Console.WriteLine(num);
                    }
                    } else {
                        Console.WriteLine("No hay actividades registradas en el sistema.");
                    }
                    Console.ReadKey();
                break;

                case "c":   
                    Console.Clear();
                    Console.WriteLine("Estas son las actividades registradas: ");
                    Console.WriteLine();
                    todos2 = mngAct.obtenerActividad();
                    if (mngAct.total()>0){
                    foreach(actividad activ in todos2){
                        Console.WriteLine("Datos del ciclista que realizo la actividad. Nombre: {0} {1} - Cedula: {2} ", activ.nombre, activ.apellido, activ.cedula); 
                        Console.WriteLine("Datos de la actividad que realizo el ciclista. Fecha: {0} - Distancia: {1} km - Lugar: {2} - Dificultad : {3}", activ.fecha, activ.distancia, activ.lugar, activ.dificultad); 
                        Console.WriteLine();     
                    }
                    } else {
                        Console.WriteLine("No hay actividades registradas.");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Para volver al menu principal, presione cualquier tecla.");
                    Console.ReadKey();
                break;

                case "z":
                    Console.Clear();
                    Console.WriteLine("Listado de ciclistas mostrados por signo zodiacal: ");
                    Console.WriteLine();
                    todos = mngCic.obtenerCiclista();
                    foreach(ciclista gente in todos){
                        int D = 0;
                        int.TryParse(gente.dia, out D);   
                        int M = 0;   
                        int.TryParse(gente.mes, out M);   

                        if ((20 >= D &&  1 == M) || (18 <= D && 2 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Acuario.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((19 >= D &&  2 == M) || (20 <= D && 3 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Piscis.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((21 >= D &&  3 == M) || (19 <= D && 4 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Aries.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((21 >= D &&  4 == M) || (19 <= D && 5 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Tauro.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((21 >= D &&  5 == M) || (20 <= D && 6 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Geminis.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((21 >= D &&  6 == M) || (22 <= D && 7 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Cancer.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((23 >= D &&  7 == M) || (22 <= D && 8 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Leo.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((23 >= D && 8 == M) || (22 <= D && 9 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Virgo.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((23 >= D &&  9 == M) || (22 <= D && 10 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Libra.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((23 >= D &&  10 == M) || (21 <= D && 11 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Escorpio.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((22 >= D &&  11 == M) || (21 <= D && 12 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Sagitario.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else if ((22 >= D &&  12 == M) || (19 <= D && 1 == M))
                        {
                            Console.WriteLine("El ciclista es {0} {1} y de cedula #{2} y su signo zodiacal es Capricornio.", gente.nombre, gente.apellido, gente.cedula);
                            Console.WriteLine();
                        } else {}

                    }
                    Console.WriteLine("Para volver al menu principal, presione cualquier tecla.");
                    Console.ReadKey();
                break;

                case "e":
                    Console.Clear();

                        Console.WriteLine("Estos son los ciclistas agregados, digite el numero del que desea exportar: ");
                        todos = mngCic.obtenerCiclista();
                        todos2 = mngAct.obtenerActividad();
                        int ma = 1;

                        foreach(ciclista gente in todos){
                            Console.WriteLine("No: {12} - Nombre: {0} - Apellido: {1} Cedula: {2} - Fecha de nacimiento: {3}/{13}/{14} - Tipo de Sangre: {4} - Size de bicicleta : {5} - Size de uniforme: {6} - Telefono: {7} - Celular: {8} - Email: {9} - Direccion: {10} - Contacto: {11} - Telefono de contacto: {9}", gente.nombre, gente.apellido, gente.cedula, gente.dia, gente.sangre, gente.sizeB, gente.sizeU, gente.telefono, gente.celular, gente.email, gente.direccion, gente.contacto, gente.tContacto, ma, gente.mes, gente.ano);
                            Console.WriteLine(); 
                        ma++;
                        }
                        
                        Console.Write("Digite el numero del ciclista que desea exportar: ");
                        int nu = 0;
                        int.TryParse(Console.ReadLine(), out nu);
                        
                        int i = 1;

                        if(i > 0 && nu <= mngCic.total() && nu !=0){

                            if (i > 0 && nu <= mngAct.total() && nu != 0){


                                string ruta = "c:\\feliz";
                                if (Directory.Exists(ruta) == false){
                                    Directory.CreateDirectory(ruta);
                                }
                                string Color = "#cccccc";
                                string contenido = "<html>"+
                                "<head>"+
                                "</head>"+
                                "<body style='background:"+Color+"'>"+
                                "<table border='1'><tr><th>Nombre</th><td>"+todos[nu-1].nombre+
                                "</td></tr><tr><th>Apellido</th><td>"+todos[nu-1].apellido+
                                "</td></tr><tr><th>Cedula</th><td>"+todos[nu-1].cedula+
                                "</td></tr><tr><th>Direccion</th><td>"+todos[nu-1].direccion+
                                "</td></tr><tr><th>Tipo de sangre</th><td>"+todos[nu-1].sangre+
                                "</td></tr><tr><th>Fecha de nacimiento</th><td>"+todos[nu-1].dia+"/"+todos[nu-1].mes+"/"+todos[nu-1].ano+
                                "</td></tr><tr><th>Tamaño de bicicleta</th><td>"+todos[nu-1].sizeB+
                                "</td></tr><tr><th>Tamaño de uniforme</th><td>"+todos[nu-1].sizeU+
                                "</td></tr><tr><th>Telefono</th><td>"+todos[nu-1].telefono+
                                "</td></tr><tr><th>Celular</th><td>"+todos[nu-1].celular+
                                "</td></tr><tr><th>Email</th><td>"+todos[nu-1].email+
                                "</td></tr><tr><th>Contacto</th><td>"+todos[nu-1].contacto+
                                "</td></tr><tr><th>Telefono del contacto</th><td>"+todos[nu-1].tContacto+
                                "</td></tr><tr><th>Fecha de la actividad</th><td>" +todos2[nu-1].fecha +
                                "</td></tr><tr><th>Distancia de la actividad (en km)</th><td>" +todos2[nu-1].distancia +
                                "</td></tr><tr><th>Lugar en cual se realizo</th><td>" +todos2[nu-1].lugar +
                                "</td></tr><tr><th>Difictultad</th><td>" +todos2[nu-1].dificultad +

                                "<</td></tr></table></body>"+
                                "</html>";

                                File.WriteAllText("c:\\feliz\\"+todos[nu-1].cedula+".html", contenido);
                            
                                Console.WriteLine("¡Listo! El ciclista fue correctamente exportado.");
                            }
                        } else {
                            Console.WriteLine("¡Hay un problema! El numero ingresado es incorrecto.");
                        }   
                    Console.ReadKey();
                break;

                case "s":
                    Console.WriteLine("Presiona 's' de nuevo para salir.");

                    FileStream stream = new FileStream("data.dat", FileMode.Create);
                    BinaryFormatter formater = new BinaryFormatter();
                    formater.Serialize(stream, mngCic);
                    stream.Close();

                    FileStream stream2 = new FileStream("data2.dat", FileMode.Create);
                    BinaryFormatter formater2 = new BinaryFormatter();
                    formater2.Serialize(stream2, mngAct);
                    stream2.Close();

                    Console.ReadKey();
                    continuar = false;
                break;

                default:
                    Console.WriteLine(entrada + " no es una opcion valida.");
                    Console.ReadKey();
                break;

            }

        }

    }

}