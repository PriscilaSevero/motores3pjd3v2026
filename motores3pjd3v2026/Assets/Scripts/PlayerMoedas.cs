using System;
using UnityEngine;

public class PlayerMoedas : MonoBehaviour
{

    private int totalMoedas = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerObserverManager.NotificarMoedasAlteradas(totalMoedas);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moeda"))
        {
            totalMoedas++;
            PlayerObserverManager.NotificarMoedasAlteradas(totalMoedas);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
