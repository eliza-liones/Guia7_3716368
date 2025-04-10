using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Guia7_3716368
{
    class conexion
    {
        public string servidor, usuario, clave, db;
        public string cadena;

        public void conec()
        {
            servidor = "ELIZABETH\\SQLEXPRESS";
            db = "BD_3716368";
            usuario = "sa";
            clave = "123456";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;

        }
    }
}
