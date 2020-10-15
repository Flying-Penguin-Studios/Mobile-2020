using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    [SerializeField] Text UI_Nome;
    [SerializeField] Slider UI_Fome;
    [SerializeField] Slider UI_Sujeira;
    [SerializeField] Slider UI_Diversao;
    [SerializeField] Text UI_Tempo;
    [SerializeField] Text UI_DataNascimento;
    [SerializeField] Text UI_Dinero;

    public string Nome
    {
        set { UI_Nome.text = "Nome :" + value; }
    }

    public float Fome
    {
        set { UI_Fome.value = value / 100; }
    }

    public float Sujeira
    {
        set { UI_Sujeira.value = value / 100; }
    }

    public float Diversao
    {
        set { UI_Diversao.value = value / 100; }
    }

    public string Tempo
    {
        set { UI_Tempo.text = "Tempo :" + value; }
    }

    public string DataNascimento
    {
        set { UI_DataNascimento.text = "Data de Nascimento :" + value; }
    }

    public int Dinheiro
    {
        set { UI_Dinero.text = value.ToString() + " <3"; }
    }
}
