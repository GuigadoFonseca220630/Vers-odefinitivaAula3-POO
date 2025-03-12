using aula_03;

// Criando a instância da classe Televisao
Televisao tvSala = new Televisao(22f);

Console.WriteLine($"Tamanho da TV: {tvSala.Tamanho}");
Console.WriteLine($"Volume inicial: {tvSala.Volume}");

// Aumentar volume
tvSala.AumentarVolume();
Console.WriteLine($"Volume após aumento: {tvSala.Volume}");

// Ativar modo mudo
tvSala.AlternarModoMudo();
Console.WriteLine("TV no modo mudo.");

// Tentar aumentar volume no modo mudo
tvSala.AumentarVolume();
Console.WriteLine($"Volume (em modo mudo): {tvSala.Volume}");

// Desativar modo mudo
tvSala.AlternarModoMudo();
Console.WriteLine($"Volume após desativar mudo: {tvSala.Volume}");

// Diminuir volume
tvSala.DiminuirVolume();
Console.WriteLine($"Volume após diminuir: {tvSala.Volume}");

// Subir canal
tvSala.SubirCanal();
Console.WriteLine($"Canal atual: {tvSala.Canal}");