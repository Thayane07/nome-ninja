
Console.WriteLine("NOME DE NINJA");
Console.Write("Diga-me seu nome: ");
string nome = Console.ReadLine()!;
string nomeNinja = nome.Trim().ToLower()
.Replace("a", "KA")
.Replace("b", "zu")
.Replace("c", "mi")
.Replace("d", "te")
.Replace("e", "ku")
.Replace("f", "lu")
.Replace("g", "ji")
.Replace("h", "ri")
.Replace("i", "ki")
.Replace("j", "zus")
.Replace("k", "me")
.Replace("l", "tA")
.Replace("m", "rin")
.Replace("n", "to")
.Replace("o", "mo")
.Replace("p", "no")
.Replace("q", "ke")
.Replace("r", "shi")
.Replace("s", "ari")
.Replace("t", "chi")
.Replace("u", "do")
.Replace("v", "ru")
.Replace("w", "mei")
.Replace("x", "na")
.Replace("y", "fu")
.Replace("z", "zi");

nomeNinja = $"{nomeNinja.Substring(0,1).ToUpper()}{nomeNinja.Substring(1).ToLower()}";
Console.WriteLine($"\nSEU NOME NINJA É {nomeNinja}.");
