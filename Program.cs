using KitchenApp.view;
using KitchenApp.model;
using KitchenApp.controller;

namespace KitchenApp
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            KitchenModel model = new KitchenModel();
            KitchenView view = new KitchenView(model);
            KitchenController controller = new KitchenController(model, view);

            controller.Start();
        }
    }
}