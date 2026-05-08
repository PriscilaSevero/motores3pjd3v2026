using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public enum EstadoDoJogo { Iniciando,MenuPrincipal,Gameplay }
    public EstadoDoJogo estadoAtual;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            estadoAtual = EstadoDoJogo.Iniciando;
        }
    }

    
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            estadoAtual = EstadoDoJogo.Iniciando;
            MudarCena("Splash", EstadoDoJogo.Iniciando);
            Debug.Log(">>> ESTADO ATUAL: " + estadoAtual);
        }
        
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            estadoAtual = EstadoDoJogo.MenuPrincipal;
            MudarCena("Menu Principal", EstadoDoJogo.MenuPrincipal);
            Debug.Log(">>> ESTADO ATUAL: " + estadoAtual);
        }
        
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            estadoAtual = EstadoDoJogo.Gameplay;
            MudarCena("Get Started_Scene", EstadoDoJogo.Gameplay);
            Debug.Log(">>> ESTADO ATUAL: " + estadoAtual);
        }
    }

    public void MudarCena(string getStartedScene, EstadoDoJogo novoEstado)
    {
        estadoAtual = novoEstado;
        Debug.Log(">>> ESTADO ATUAL: " + estadoAtual);
        SceneManager.LoadScene(getStartedScene);
    }

    public void AlocarInputAoJogador(PlayerInput playerInput)
    {
        if (playerInput != null) Debug.Log("Input Alocado!");
    }
}