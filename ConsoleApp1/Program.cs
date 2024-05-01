string percorsoFile = "C:\\Documenti\\Immagini";
        string nuovaRiga = "Questa è una stringa con una nuova riga\n";
        string tabulazione = "\tQuesta è una stringa con una tabulazione";

        // Stringa verbatim
        string percorsoFileVerbatim = @"C:\Documenti\Immagini";

        // Output delle stringhe
        Console.WriteLine("Stringa con caratteri speciali:");
        Console.WriteLine(percorsoFile);
        Console.WriteLine(nuovaRiga);
        Console.WriteLine(tabulazione);

        Console.WriteLine("\nStringa con caratteri verbatim:");
        Console.WriteLine(percorsoFileVerbatim);