using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("¼ÒÁö °ñµå")]
    public static int Money;

    [Header("Ã³À½ °ñµå")]
    public int startMoney = 400;

    private void Start()
    {
        Money = startMoney;
    }

}
