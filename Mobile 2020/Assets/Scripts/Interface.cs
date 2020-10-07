using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    [SerializeField] Text UI_Nome;
    [SerializeField] Text UI_Fome;
    [SerializeField] Text UI_Sujeira;
    [SerializeField] Text UI_Diversao;
    [SerializeField] Text UI_Tempo;
    [SerializeField] Text UI_DataNascimento;

    public string Nome
    {
        set { UI_Nome.text = "Nome :" + value; }
    }

    public string Fome
    {
        set { UI_Fome.text = "Fome :" + value; }
    }

    public string Sujeira
    {
        set { UI_Sujeira.text = "Sujeira :" + value; }
    }

    public string Diversao
    {
        set { UI_Diversao.text = "Diversão :" + value; }
    }

    public string Tempo
    {
        set { UI_Tempo.text = "Tempo :" + value; }
    }

    public string DataNascimento
    {
        set { UI_DataNascimento.text = "Data de Nascimento :" + value; }
    }
}
