using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashTimer : MonoBehaviour
{
    void Start()
    {
        Invoke("IrParaMenu", 2f);
    }

    void IrParaMenu()
    {
        
        GameManager.Instance.MudarCena("Menu Principal", GameManager.EstadoDoJogo.MenuPrincipal);
    }
}