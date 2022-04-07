using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeDbAticma.Models;
using System.Data.SqlClient;
using System.Data;

namespace ChallengeDbAticma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string de conexion
            SqlConnection conn = new SqlConnection("server=DESKTOP-N482O5J\\SQLEXPRESS;database=ChallengeDbAticma;Integrated Security=true");
            Console.WriteLine("Si quiere cargar alumno ingrese 1");
            Console.WriteLine("Si quiere cargar universidad ingrese 2");
            Console.WriteLine("Si quiere cargar materia ingrese 3");
            Console.WriteLine("Si quiere cargar una nota de un alumno ingrese 4");
            Console.WriteLine("Mostrar resultado de ejercicio 4, Ingrese 5");
            int opcion= Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        //Abro conexion, pido el ingreso de datos, lo asigno a variables
                        //hago el insert con las variables y lo ejecuto
                        conn.Open();
                        Console.WriteLine("Inserte nombre del alumno:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Inserte apellido del alumno:");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Inserte telefono del alumno:");
                        string tel = Console.ReadLine();
                        Console.WriteLine("Inserte email del alumno:");
                        string email = Console.ReadLine();
                        string query = "INSERT INTO Alumno (Nombre, Apellido, Telefono, Email) VALUES ('" + nombre + "','" + apellido + "','" + tel + "','" + email + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Alumno guardado correctamente");
                        Console.ReadKey();
                        break;
                    }
                    case 2:
                    {
                        //Abro conexion, pido el ingreso de datos, lo asigno a variables
                        //hago el insert con las variables y lo ejecuto
                        conn.Open();
                        Console.WriteLine("Inserte nombre de la universidad:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Inserte provincia:");
                        string prov = Console.ReadLine();
                        Console.WriteLine("Inserte localidad:");
                        string loc = Console.ReadLine();
                        string query = "INSERT INTO Universidad (Nombre, Provincia, Localidad) VALUES ('" + nombre + "','" + prov + "','" + loc + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Universidad guardada correctamente");
                        Console.ReadKey();
                        break ;
                    }
                    case 3:
                    {
                        //Abro conexion, pido el ingreso de datos, lo asigno a variables
                        //hago el insert con las variables y lo ejecuto
                        conn.Open();
                        Console.WriteLine("Inserte nombre de la materia:");
                        string nombre = Console.ReadLine();
                        string query = "INSERT INTO Materia (Nombre) VALUES ('" + nombre + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Materia guardada correctamente");
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        //Abro conexion, pido el ingreso de datos, lo asigno a variables
                        //hago el insert con las variables y lo ejecuto
                        conn.Open();
                        Console.WriteLine("Ingrese el Id del alumno");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el Id de la materia");
                        int idMat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la nota");
                        int nota = Convert.ToInt32(Console.ReadLine());
                        string query = "INSERT INTO Nota (IDMateria, IDAlumno, Calificacion) VALUES ("+idMat+","+id+"," + nota + ")";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Nota guardada correctamente");
                        Console.ReadKey();

                        break;
                    }
                case 5:
                    {
                        //abro conexion, hago el select, ejecuto el comando, lo asigno a una tabla
                        //recorro la tabla e imprimo en pantalla
                        //el select tiene joins para unir las tablas y seleccionar diferentes campos
                        //se ordena con group by y se filtra segun promedio mayor a 7 y mayor a 12 materias
                        conn.Open();
                        string query = "Select Alumno.Nombre, Alumno.Apellido, Alumno.Telefono, Alumno.email, Universidad.Nombre,Universidad.Provincia, Universidad.Localidad,AVG(Calificacion) as prom from Universidad join AlumnoUni on Universidad.IDUniversidad = AlumnoUni.IDUniversidad join Alumno on Alumno.IDAlumno = AlumnoUni.IDAlumno join nota on Alumno.IDAlumno = nota.IDAlumno group by Alumno.Nombre, Alumno.Apellido, Alumno.Telefono, Alumno.Email, Universidad.Nombre, Universidad.Provincia, Universidad.Localidad having AVG(calificacion) > 7 and count(IDMateria) > 12";
                        SqlCommand cmd = new SqlCommand(query,conn);
                        var da = new SqlDataAdapter(cmd);
                        var dt = new DataTable();
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            Console.WriteLine(dr[0]);
                        }
                        Console.ReadKey();
                        break ;
                    }
            }
            
        }
    }
}
