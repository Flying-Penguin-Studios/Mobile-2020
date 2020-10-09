using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public Ilan Bixin;
    [HideInInspector] public int Dinheiro;

    public void Init()
    {
        Bixin = new Ilan("Ronaldinho");
        Dinheiro = 100;
    }
}
