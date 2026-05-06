using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.InputSystem;    

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance { get; private set; }

    
    public enum JogoEstado { Iniciando, MenuPrincipal, Gameplay }
    public JogoEstado estadoAtual;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void MudarCena(string GetStarted_scene, JogoEstado novoEstado)
    {
        
        if (estadoAtual == JogoEstado.Iniciando || novoEstado != JogoEstado.Iniciando)
        {
            estadoAtual = novoEstado;
            SceneManager.LoadScene(GetStarted_scene);
        }
    }

    
    public void ConfigurarControle(PlayerInput playerInput)
    {
        Debug.Log("Controle está entregue.");
        
    }
}
