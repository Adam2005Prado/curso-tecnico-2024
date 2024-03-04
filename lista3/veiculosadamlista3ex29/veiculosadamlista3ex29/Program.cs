namespace veiculosadamlista3ex29
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Write("Insira o modelo do veículo:");
            string modelo = Console.ReadLine();

            tipoveiculo tipo = obtertipoveiculo(modelo);

            exibirtipoveiculo(tipo);
        }

        public enum tipoveiculo
        {
            carro,
            moto,
            caminhao,
            desonhecido
        }

        public static tipoveiculo obtertipoveiculo(string modelo)
        {
            if (modelo.ToLower().Contains("Carro"))
            { return tipoveiculo.carro; }

            else if (modelo.ToLower().Contains("Caminhão"))
            { return tipoveiculo.caminhao; }

            else if (modelo.ToLower().Contains("Moto"))
            { return tipoveiculo.moto; }

            else
            {
                return tipoveiculo.desonhecido;
            }
        }

        public static void exibirtipoveiculo( tipoveiculo tipo)
        {
            
                    
            }
        }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}