 Console.WriteLine("O FLUXOGRAMA DA ENGENHARIA\n");

        Console.Write("Está se movendo? (s/n): ");
        string movendo = Console.ReadLine().Trim().ToLower();

        if (movendo == "s")
        {
            Console.Write("Deveria? (s/n): ");
            string deveria = Console.ReadLine().Trim().ToLower();

            if (deveria == "s")
            {
                Console.WriteLine("ÓTIMO");
            }
            else if (deveria == "n")
            {
                Console.WriteLine("Use fita adesiva (silver tape).");
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
            }
        }
        else if (movendo == "n")
        {
            Console.Write("Deveria? (s/n): ");
            string deveria = Console.ReadLine().Trim().ToLower();

            if (deveria == "n")
            {
                Console.WriteLine("ÓTIMO");
            }
            else if (deveria == "s")
            {
                Console.WriteLine("Use WD-40.");
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
            }
        }
        else
        {
            Console.WriteLine("Resposta inválida.");
        }