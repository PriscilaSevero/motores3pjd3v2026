<<<<<<< HEAD
using UnityEngine;
using System;

public class PlayerObserverManager : MonoBehaviour
{
    public static Action<StarterAssets.ThirdPersonController> OnCoinCollected;

    public static Action<StarterAssets.ThirdPersonController, int> OnCoinCountChanged;

    public static Action OnAllCoinsCollected;

    public static Action<StarterAssets.ThirdPersonController> OnStarCollected;

    public static Action OnAllStarsCollected;

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

    public static void NotifyStarCollected(StarterAssets.ThirdPersonController player)
    {
        OnStarCollected?.Invoke(player);
    }

    public static void NotifyAllStarsCollected()
    {
        OnAllStarsCollected?.Invoke();
    }
=======
using System;

public static class PlayerObserverManager
{
    public static event Action<int> OnMoedasAlteradas;
    public static void NotificarMoedasAlteradas(int quantidade)
    {
        OnMoedasAlteradas?.Invoke(quantidade);
    }
    
   
>>>>>>> d8c0f6118bd357172b40678661437d93f191e297
}