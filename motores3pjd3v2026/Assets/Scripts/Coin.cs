using StarterAssets;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLISÃO COM A MOEDA: " + other.name);

        if (!other.CompareTag("Player"))
            return;

        ThirdPersonController player = other.GetComponentInParent<ThirdPersonController>();

        if (player == null)
            return;

        PlayerObserverManager.NotifyCoinCollected(player);

        Coin[] remainingCoins = FindObjectsByType<Coin>(FindObjectsSortMode.None);

        Debug.Log("MOEDAS RESTANTES: " + remainingCoins.Length);

        if (remainingCoins.Length == 1)
        {
            Debug.Log("TODAS AS MOEDAS FORAM COLETADAS!");
            PlayerObserverManager.NotifyAllCoinsCollected();
        }

        Destroy(gameObject);
    }
}