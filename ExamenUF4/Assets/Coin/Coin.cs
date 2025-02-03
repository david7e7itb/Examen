using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollected()
    {
        GameManager.gameManager.CoinCollected();
        Destroy(gameObject);
    }
}
