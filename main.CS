Console.Write("Digite a temperatura atual em graus celsius: ");
            int temperatura = Convert.ToInt32(Console.ReadLine());

            if (temperatura >= 35)
            {
                Console.WriteLine("Está muito quente! Reforce a hidratação.");
            }
            else if (temperatura >= 25)
            {
                Console.WriteLine("Tempo agradável! Aproveite o dia.");
            }
            else if (temperatura >= 15)
            {
                Console.WriteLine("Clima ameno! Talvez um casaco leve seja útil.");
            }
            else
            {
                Console.WriteLine("Está frio! Agasalhe-se bem.");
            }

            Console.WriteLine("Que horas você volta para casa? ");
            int horas = Convert.ToInt32(Console.ReadLine());
            

            if (horas >= 18)
            {
                temperatura = temperatura - 10;

                Console.WriteLine("Temperatura prevista: " + temperatura);

                if (temperatura >= 35)
                {
                    Console.WriteLine("Estará muito quente! Reforce a hidratação.");
                }
                else if (temperatura >= 25)
                {
                    Console.WriteLine("Tempo estará agradável! Aproveite a noite.");
                }
                else if (temperatura >= 15)
                {
                    Console.WriteLine("Clima estará ameno! Talvez um casaco leve seja útil.");
                }
                else
                {
                    Console.WriteLine("Estará frio! Agasalhe-se bem.");
                }
            }
            else
            {
                Console.WriteLine("A temperatura continuará normal!");
            }
            Console.ReadKey();
