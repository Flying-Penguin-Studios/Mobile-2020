using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static Controller Singleton;

    void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Player Player;
    public Interface UI;

    // Start is called before the first frame update
    void Start()
    {
        Player.Init();

        UI.Nome = Player.Bixin.Name;
        UI.Fome = Player.Bixin.Fome;
        UI.Sujeira = Player.Bixin.Sujeira;
        UI.Diversao = Player.Bixin.Diversao;
        //UI.Tempo = Bixin.BornDate;        
        UI.DataNascimento = Player.Bixin.BornDate.ToString("dd/MM/yyyy");
        UI.Dinheiro = Player.Dinheiro;

        StartCoroutine(Fome());
        StartCoroutine(Limpeza());
        StartCoroutine(Diversao());
    }

    IEnumerator Fome()
    {
        while (true)
        {
            Player.Bixin.Fome--;
            UI.Fome = Player.Bixin.Fome;
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Limpeza()
    {
        while (true)
        {
            Player.Bixin.Sujeira--;
            UI.Sujeira = Player.Bixin.Sujeira;
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Diversao()
    {
        while (true)
        {
            Player.Bixin.Diversao--;
            UI.Diversao = Player.Bixin.Diversao;
            yield return new WaitForSeconds(1f);
        }
    }

    public void Carinho()
    {
        Player.Dinheiro++;
        UI.Dinheiro = Player.Dinheiro;
    }

    public void Comida()
    {
        Player.Bixin.Fome++;
        UI.Fome = Player.Bixin.Fome;
    }

    public void Limpar()
    {
        Player.Bixin.Sujeira++;
        UI.Sujeira = Player.Bixin.Sujeira;
    }

    public void Brincar()
    {
        Player.Bixin.Diversao++;
        UI.Diversao = Player.Bixin.Diversao;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Comida();
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            Limpar();
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            Brincar();
        }
    }
}
