using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    //In-Game currency
    public static int Money;
    public int startOffMoney = 500;

    //In-Game Lives :D
    public static int Lives;
    private int startLives = 3;
    void Start()
    {
        Money = startOffMoney;
        Lives = startLives;
    }
}
