using System.Runtime.InteropServices;

namespace LabDatos2
{
    // Estructura clásica, segura para .NET Framework
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct Ciudadano
    {
        public int Id;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        public string Nombre;

        public int Edad;

        public static int Size => Marshal.SizeOf(typeof(Ciudadano));
    }
}