namespace InventarioExcel.Main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Establecer el modo de alta DPI (SystemAware o PerMonitor dependiendo de lo que necesites)
            Application.SetHighDpiMode(HighDpiMode.SystemAware); // Puedes cambiarlo a PerMonitor o PerMonitorV2 si lo necesitas

            // Inicializar la configuración de la aplicación
            ApplicationConfiguration.Initialize();

            // Ejecutar la aplicación
            Application.Run(new MainCode());
        }
    }
}
