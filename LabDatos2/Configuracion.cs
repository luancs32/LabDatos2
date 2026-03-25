using System;
using System.Collections.Generic;
using System.Text;

namespace LabDatos2
{
    internal class Configuracion
    {
        // ══════════════════════════════════════════════
        //  CAMBIA SOLO ESTA LÍNEA AL CAMBIAR DE RED
        // ══════════════════════════════════════════════
        private static readonly string Servidor = "10.12.13.166,1433";

        //susus
        // y descomenta la que corresponda:
        // private static readonly string Servidor = "192.168.1.77,1433";
        // private static readonly string Servidor = "localhost,1433";

        // ══════════════════════════════════════════════
        //  NO TOQUES LO DE ABAJO
        // ══════════════════════════════════════════════
        private const string BaseDatos = "LabDatos2";
        private const string Usuario = "sa";
        private const string Password = "123";

        public static string CadenaConexion =>
            $"Server={Servidor};Database={BaseDatos};User Id={Usuario};Password={Password};TrustServerCertificate=True;";
    }
}
