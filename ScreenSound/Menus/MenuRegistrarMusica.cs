﻿using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(Dal<Artista> artistasDal)
    {
        base.Executar(artistasDal);
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite o artista cuja música deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        var artistaRecuperado = artistasDal.RecuperarPor(a => a.Nome.Equals(nomeDoArtista));
        if (artistaRecuperado is not null)
        {
            Console.Write("Agora digite o título da música: ");
            string tituloDaMusica = Console.ReadLine()!;
            Console.Write("Agora digite o o ano de lançamento da música: ");
            int anoLancamento = int.Parse(Console.ReadLine()!);
            artistaRecuperado.AdicionarMusica(new Musica(tituloDaMusica) { AnoLancamento = anoLancamento});
            Console.WriteLine($"A música {tituloDaMusica} de {nomeDoArtista} foi registrada com sucesso!");
            artistasDal.Atualizar(artistaRecuperado);
            Thread.Sleep(4000);
            Console.Clear();
            
        }
        else
        {
            Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
