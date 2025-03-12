namespace aula_03;

public class Televisao
{
    // Construtor da classe Televisao
    public Televisao(float tamanho)
    {
        if (tamanho < TAMANHO_MINIMO || tamanho > TAMANHO_MAXIMO)
        {
            throw new ArgumentOutOfRangeException($"O tamanho ({tamanho}) não é suportado!");
        }
        Tamanho = tamanho;
        Volume = VOLUME_PADRAO;
        Canal = CANAL_PADRAO;
    }

    // Constantes para configuração e validação
    private const float TAMANHO_MINIMO = 22;
    private const float TAMANHO_MAXIMO = 80;
    private const int VOLUME_MAXIMO = 12;
    private const int VOLUME_MINIMO = 0;
    private const int VOLUME_PADRAO = 10;
    private const int CANAL_PADRAO = 17;

    // Campo privado para armazenar o último volume antes de ativar o modo mudo
    private int _ultimoVolume = VOLUME_PADRAO;

    // Propriedades públicas
    public float Tamanho { get; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }

    // Métodos para alterar o volume
    public void AumentarVolume()
    {
        if (Volume < VOLUME_MAXIMO)
        {
            Volume++;
            _ultimoVolume = Volume;
        }
        else
        {
            Console.WriteLine("A TV já está no volume máximo permitido.");
        }
    }

    public void DiminuirVolume()
    {
        if (Volume > VOLUME_MINIMO)
        {
            Volume--;
            _ultimoVolume = Volume;
        }
        else
        {
            Console.WriteLine("A TV já está no volume mínimo permitido.");
        }
    }

    // Alternar modo mudo (toggle)
    public void AlternarModoMudo()
    {
        if (Volume > VOLUME_MINIMO)
        {
            _ultimoVolume = Volume;
            Volume = VOLUME_MINIMO;
            Console.WriteLine("A TV está no modo MUTE.");
        }
        else
        {
            Volume = _ultimoVolume;
            Console.WriteLine($"O volume da TV foi restaurado para: {Volume}.");
        }
    }

    // Métodos para trocar canal
    public void SubirCanal()
    {
        Canal++;
        Console.WriteLine($"Canal atual: {Canal}");
    }

    public void DescerCanal()
    {
        Canal--;
        Console.WriteLine($"Canal atual: {Canal}");
    }
}