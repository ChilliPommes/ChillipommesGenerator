namespace ChillipommesGenerator.GUI
{
    /// <summary>
    /// Text renderer class for console application
    /// </summary>
    internal class Renderer
    {
        private string[] _lines;

        /// <summary>
        /// Constructor with default initialisations for private fields
        /// </summary>
        public Renderer() 
        {
            _lines = new string[0];
        }

        /// <summary>
        /// Adds a line for rendering at the end of the array
        /// </summary>
        /// <param name="line"></param>
        public void AddLine(string line)
        {
            string[] lineCache = new string[_lines.Length + 1];

            for(int i = 0; i < lineCache.Length; i++)
            {
                if (i != lineCache.Length - 1)
                {
                    lineCache[i] = _lines[i];
                }
                else
                {
                    lineCache[i] = line;
                }
            }

            _lines = lineCache;
        }

        /// <summary>
        /// Renders the setted lines to the console gui
        /// </summary>
        public void Render()
        {
            foreach(var line in _lines)
            {
                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// Clears the lines for rendering
        /// </summary>
        public void Clear()
        {
            _lines = new string[0];
        }

        /// <summary>
        /// Clears the complete console
        /// </summary>
        public static void ClearConsole()
        {
            Console.Clear();
        }
    }
}
