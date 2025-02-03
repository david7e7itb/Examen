using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seller : MonoBehaviour
{
    public GameObject interactionUI; 
    public Button increaseCoinButton; 
    private int coins = 0;
    

    private void Start()
    {
        interactionUI.SetActive(false);  
        if (increaseCoinButton != null)
            increaseCoinButton.onClick.AddListener(IncreaseCoins);  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            interactionUI?.SetActive(true); 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            interactionUI?.SetActive(false); 
    }
     void IncreaseCoins()
    {
        coins++;  
        Debug.Log("Monedas: " + coins);  
    }
}