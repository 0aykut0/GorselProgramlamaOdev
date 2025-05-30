using gorselProgramlamaProje.Forms;

namespace gorselProgramlamaProje
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AnaSayfaForm());
        }
    }
}
