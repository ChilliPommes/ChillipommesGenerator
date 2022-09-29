namespace ChillipommesGenerator.GUI
{
    internal class StartUp
    {
        public static void ApplicationStartUpText()
        {
            Renderer renderer = new Renderer();

            renderer.AddLine(" |||||||   |||||||   ||     ||   ||     ||   |||||||   |||||||");
            renderer.AddLine(" ||   ||   ||   ||   |||   |||   |||   |||   ||        ||");
            renderer.AddLine(" ||   ||   ||   ||   || | | ||   || | | ||   ||        ||");
            renderer.AddLine(" |||||||   ||   ||   ||  |  ||   ||  |  ||   |||||     |||||||");
            renderer.AddLine(" ||        ||   ||   ||     ||   ||     ||   ||             ||");
            renderer.AddLine(" ||        ||   ||   ||     ||   ||     ||   ||             ||");
            renderer.AddLine(" ||        |||||||   ||     ||   ||     ||   |||||||   |||||||");
            renderer.AddLine("");
            renderer.AddLine(" |||||||   |||||||   |||        |||||||");
            renderer.AddLine(" ||        ||   ||   || ||      ||");
            renderer.AddLine(" ||        ||   ||   ||   ||    ||");
            renderer.AddLine(" ||        ||   ||   ||    ||   |||||");
            renderer.AddLine(" ||        ||   ||   ||   ||    ||");
            renderer.AddLine(" ||        ||   ||   || ||      ||");
            renderer.AddLine(" |||||||   |||||||   |||        |||||||");
            renderer.AddLine("");
            renderer.AddLine(" |||||||   |||||||   ||     ||");
            renderer.AddLine(" ||        ||        |||    ||");
            renderer.AddLine(" ||        ||        || |   ||");
            renderer.AddLine(" ||  |||   |||||     ||  |  ||");
            renderer.AddLine(" ||   ||   ||        ||   | ||");
            renderer.AddLine(" ||   ||   ||        ||    |||");
            renderer.AddLine(" |||||||   |||||||   ||     ||");

            renderer.AddLine("");
            renderer.AddLine("");
            renderer.AddLine("");

            renderer.AddLine("Welcome to the official source code generator made by");
            renderer.AddLine("Chillipommes");
            renderer.AddLine("");
            renderer.AddLine("Reports for bugs or features goes to :");
            renderer.AddLine("https://github.com/ChilliPommes/ChillipommesGenerator");
            renderer.AddLine("");
            renderer.AddLine("Press Enter to continue...");

            renderer.Render();

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                // do nothing just read for key :D
            }

            Renderer.ClearConsole();
        }
    }
}
