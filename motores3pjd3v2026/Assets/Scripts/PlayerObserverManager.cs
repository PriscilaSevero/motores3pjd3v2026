using UnityEngine;
using System;

public class PlayerObserverManager : MonoBehaviour
{
    public static Action<StarterAssets.ThirdPersonController> OnCoinCollected;

    public static Action<StarterAssets.ThirdPersonController, int> OnCoinCountChanged;

    public static Action OnAllCoinsCollected;

    public static void NotifyCoinCollected(StarterAssets.ThirdPersonController player)
    {
        OnCoinCollected?.Invoke(player);
    }

    public static void NotifyCoinCountChanged(StarterAssets.ThirdPersonController player, int amount)
    {
        OnCoinCountChanged?.Invoke(player, amount);
    }

    public static void NotifyAllCoinsCollected()
    {
        OnAllCoinsCollected?.Invoke();
    }
}