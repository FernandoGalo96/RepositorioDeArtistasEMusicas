using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicasPorAno : Menu
{
    public override void Executar(Dal<Artista> artistasDal)
    {
        base.Executar(artistasDal);
        ExibirTituloDaOpcao("Exibir detalhes do artista");
        Console.Write("Digite o ano da música que deseja recuperar : ");
        int musicaRecuperada = int.Parse(Console.ReadLine()!);
        var musicaDal = new Dal<Musica>(new ScreenSoundContext());
        var listaAno = musicaDal.RecuperarPorAno(a => a.AnoLancamento == musicaRecuperada);
        
        if (listaAno.Any())
        {
            Console.WriteLine($"Músicas do ano: {musicaRecuperada}");
            foreach(var ano in listaAno)
            {
                ano.ExibirFichaTecnica();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();



        }
        else
        {
            Console.WriteLine($"\nO artista {listaAno} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
