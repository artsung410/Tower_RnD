using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("���� ���")]
    public static int Money;

    [Header("ó�� ���")]
    public int startMoney = 400;

    private void Start()
    {
        Money = startMoney;
    }

}
