using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public enum EstadoDoJogo 
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public EstadoDoJogo estadoAtual;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            MudarCena("Splash", EstadoDoJogo.Iniciando);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void MudarCena(string nomeDaCena, EstadoDoJogo novoEstado)
    {
        estadoAtual = novoEstado;
        Debug.Log(">>> ESTADO ATUAL: " + estadoAtual);
        SceneManager.LoadScene(nomeDaCena);
    }


    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}



