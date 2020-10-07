using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Ilan
{
    private string name;
    private int fome;
    private int sujeira;
    private int diversao;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Fome
    {
        get { return fome; }
        set { fome = Truncate(value, 0, 100); }
    }
    public int Sujeira
    {
        get { return sujeira; }
        set { sujeira = Truncate(value, 0, 100); }
    }
    public int Diversao
    {
        get { return diversao; }
        set { diversao = Truncate(value, 0, 100); }
    }

    public float LifeTime;

    public DateTime BornDate;

    public Ilan(string New_Name)
    {
        Name = New_Name;
        Fome = 100;
        Sujeira = 100;
        Diversao = 100;
        LifeTime = 0;
        BornDate = DateTime.Now;
    }

    int Truncate(int Val, int MinVal, int MaxVal)
    {
        if (Val >= MaxVal)
            return MaxVal;
        else if (Val <= MinVal)
            return MinVal;
        else
            return Val;
    }

}
