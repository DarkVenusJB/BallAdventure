using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScore : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;
    [SerializeField] private GameStats stats;

    private void Update()
    {
        coinText.text = "Coins: " + stats.coins;
    }
}
