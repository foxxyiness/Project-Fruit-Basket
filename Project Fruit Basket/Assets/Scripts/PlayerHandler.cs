using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHandler : MonoBehaviour
{
    //In-Game currency
    public static int Money;
    public int startOffMoney = 500;
    public TextMeshProUGUI livesCounter;
    public TextMeshProUGUI moneyCounter;
    //In-Game Lives :D
    public static int Lives;
    private int startLives = 3;
    void Start()
    {
        Money = startOffMoney;
        Lives = startLives;
    }

    void Update()
    {
        livesCounter.text = Mathf.Floor(Lives).ToString();
        moneyCounter.text = Mathf.Floor(Money).ToString();
    }
}
