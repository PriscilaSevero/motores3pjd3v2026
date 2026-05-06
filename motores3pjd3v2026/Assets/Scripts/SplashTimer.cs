using UnityEngine;
using System.Collections;

public class SplashTimer : MonoBehaviour
{
    void Start()
    {
        
        StartCoroutine(EsperarEPular());
    }

    IEnumerator EsperarEPular()
    {
        yield return new WaitForSeconds(2f); 
        
        
        GameManager.Instance.MudarCena("Menu de Entrada", GameManager.JogoEstado.MenuPrincipal);
    }
}