
Console.WriteLine("SOLETRANDO \n");
Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine()!;
var caracteres = palavra.ToCharArray();
string palavraSoletrada = String.Join('-', caracteres).ToUpper();

Console.WriteLine($"\nSoletrando \"{palavra.ToUpper()}\": {palavraSoletrada} \n");
