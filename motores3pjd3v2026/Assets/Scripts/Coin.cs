using StarterAssets;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        ThirdPersonController player = other.GetComponentInParent<ThirdPersonController>();

        if (player == null)
            return;

        PlayerObserverManager.NotifyCoinCollected(player);

        Coin[] remainingCoins = FindObjectsByType<Coin>(FindObjectsSortMode.None);

        if (remainingCoins.Length == 1)
        {
            PlayerObserverManager.NotifyAllCoinsCollected();
        }

        Destroy(gameObject);
    }
}