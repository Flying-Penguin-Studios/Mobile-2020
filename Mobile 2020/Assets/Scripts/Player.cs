using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Ilan Bixin;
    [SerializeField] Interface UI;

    void Start()
    {
        Bixin = new Ilan("Ronaldinho");
        UI.Nome = Bixin.Name;
        UI.Fome = Bixin.Fome.ToString();
        UI.Sujeira = Bixin.Sujeira.ToString();
        UI.Diversao = Bixin.Diversao.ToString();
        //UI.Tempo = Bixin.BornDate;        
        UI.DataNascimento = Bixin.BornDate.ToString("dd/MM/yyyy");
    }
}
