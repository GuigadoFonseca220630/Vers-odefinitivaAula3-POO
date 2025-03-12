using aula_03;

// Criando a instância da classe Televisao
Televisao tvSala = new Televisao(22f);

Console.WriteLine($"O tamanho da TV é: {tvSala.Tamanho}");
Console.WriteLine($"O volume inicial da TV é: {tvSala.Volume}");

tvSala.AumentarVolume();
Console.WriteLine($"O volume da TV após aumento é: {tvSala.Volume}");

// Ativar modo mudo
tvSala.AlternarModoMudo();
Console.WriteLine("TV no modo mudo.");

// Aumentar volume mesmo no modo mudo
tvSala.AumentarVolume();
Console.WriteLine($"O volume da TV (ainda no modo mudo) é: {tvSala.Volume}");

// Desativar modo mudo
tvSala.AlternarModoMudo();
Console.WriteLine($"O volume da TV após desativar o mudo é: {tvSala.Volume}");

// Diminuir volume
tvSala.DiminuirVolume();
Console.WriteLine($"O volume da TV após diminuir é: {tvSala.Volume}");

// Subir canal
tvSala.SubirCanal();
Console.WriteLine($"Canal atual da TV: {tvSala.Canal}");