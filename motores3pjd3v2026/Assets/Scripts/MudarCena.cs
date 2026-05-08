using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{

    public string GetStarted_Scene;

    public void Carregar()
    {
        SceneManager.LoadScene(GetStarted_Scene);
    }

}