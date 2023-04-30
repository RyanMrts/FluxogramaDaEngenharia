
string resposta;
Console.WriteLine("O objeto esta se mexendo(S/N)?");
 string mexendo = (Console.ReadLine()!.Substring(0, 1).ToUpper()); 

Console.WriteLine("Deveria?");
 string deveria = (Console.ReadLine()!.Substring(0, 1).ToUpper()); 
if (mexendo == "N") 
{
    if (deveria == "S") 
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        resposta = "Use WD-40.";
        Console.ResetColor();
    }
    else
    {
        resposta = "Ótimo !";
    }
}
else
{
    if (deveria == "N")
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        resposta = "Use Silver Tape.";
        Console.ResetColor();
    }
    else
    {
        resposta = "Ótimo !";
    }
}
Console.WriteLine(resposta);