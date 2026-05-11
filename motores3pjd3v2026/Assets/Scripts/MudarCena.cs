using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{
    public void IniciarJogo()
    {
        
        GameManager.Instance.MudarCena("GetStarted_Scene", GameManager.EstadoDoJogo.Gameplay);
    }

    public void Sair()
    {
        GameManager.Instance.SairDoJogo();
    }
}
