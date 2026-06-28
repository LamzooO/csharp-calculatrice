


    string ouiNon;
    
    bool exit = true;


    Console.WriteLine("=== Calculatrice ===");

    do
    {
    try
    {
        var (nombre1, operation, nombre2) = SaisiUtilisateur();
        double resultat = EffectuerCalcul(nombre1, operation, nombre2);
        Console.WriteLine("Resultat = " + resultat);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }



    Console.Write("Voulez-vous continuer ? (oui/non) : ");
    ouiNon = Console.ReadLine().ToLower();
        if (ouiNon == "oui")
        {
            exit = true;
    }
    else if (ouiNon == "non")
    {
        exit = false;
    }
    }
    while (exit == true);



static (double nombre1, string operateur, double nombre2) SaisiUtilisateur()
{
    string saisi;
    double nombre = 0;
    double nombre1 = 0;
    double nombre2 = 0;
    string operateur = "";

    Console.Write("Entrez le premier nombre : ");
    saisi = Console.ReadLine();

        while (!double.TryParse(saisi, out nombre))
        {
            Console.WriteLine("Veuillez saisir un nombre valide :");
            saisi = Console.ReadLine();
        }
        nombre1 = nombre;
 

    Console.Write("Entrez l'opération (+, -, *, /, %) : ");
    saisi = Console.ReadLine();
    while(saisi != "+" && saisi != "-" && saisi != "/" && saisi != "*" && saisi != "%")
    {
        Console.WriteLine("Veillez saisir une operation valide :");
        saisi = Console.ReadLine();
    }
         operateur = saisi;

    Console.Write("Entrez le deuxieme nombre : ");
    saisi = Console.ReadLine();

        while (!double.TryParse(saisi, out nombre))
        {
            Console.WriteLine("Veuillez saisir un nombre valide :");
            saisi = Console.ReadLine();
        }
        nombre1 = nombre;
    
    return (nombre1, operateur, nombre2);

}

static double EffectuerCalcul(double nombre1, string operateur, double nombre2)
{
  

    switch (operateur)
    {
        case "+":

            return Additioner(nombre1, nombre2);

        case "-":

            return Soustraire(nombre1, nombre2);

        case "/":

            return Diviser(nombre1, nombre2);

        case "*":

            return Multiplier(nombre1, nombre2);

        case "%":

            return Modulo(nombre1, nombre2);

        default:
            return 0;
    }


}

static double Additioner (double nombre1, double nombre2)
{
    double resultat = nombre1 + nombre2;
    return resultat;
}

static double Soustraire (double nombre1, double nombre2)
{
    double resultat = nombre1 - nombre2;
    return resultat;
}

static double Diviser (double nombre1, double nombre2)
{
    double resultat = 0;
  
    if (nombre2 == 0)
    {
        throw new DivideByZeroException("Impossible de diviser par 0");
    }

    resultat = nombre1 / nombre2;
    return resultat;

   
}

static double Multiplier (double nombre1, double nombre2)
{
    double resultat = nombre1 * nombre2;
    return resultat;
}

static double Modulo (double nombre1, double nombre2)
{
    double resultat = nombre1 % nombre2;
    return resultat;
}