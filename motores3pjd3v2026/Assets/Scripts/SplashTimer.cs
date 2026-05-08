using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashTimer : MonoBehaviour
{
    void Start()
    {
        Invoke("IrParaOMenuPrincipal", 2f);
    }

    void IrParaOMenuPrincipal()
    {

        SceneManager.LoadScene("Menu Principal");
    }

}