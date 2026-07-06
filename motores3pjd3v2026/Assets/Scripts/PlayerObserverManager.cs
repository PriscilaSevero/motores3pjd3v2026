using System;

public static class PlayerObserverManager
{
    public static event Action<int> OnMoedasAlteradas;
    public static void NotificarMoedasAlteradas(int quantidade)
    {
        OnMoedasAlteradas?.Invoke(quantidade);
    }
    
   
}