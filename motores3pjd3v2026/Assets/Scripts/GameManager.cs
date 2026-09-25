using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
<<<<<<< HEAD

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState currentState;

    public PlayerInput playerInput;

    public enum GameState
=======
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    
    
    public TextMeshProUGUI msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    public enum EstadoJogo
>>>>>>> d8c0f6118bd357172b40678661437d93f191e297
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

<<<<<<< HEAD
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
=======
    public EstadoJogo estadoAtual;
    private PlayerInput entradaJogador;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
>>>>>>> d8c0f6118bd357172b40678661437d93f191e297
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
<<<<<<< HEAD
        }
    }

    private void Start()
    {
        ChangeState(GameState.Iniciando);
        SceneManager.LoadScene("Splash");
    }

    public void ChangeState(GameState newState)
    {
        currentState = newState;
        Debug.Log("Estado atual: " + currentState);
    }

    public void LoadScene(string sceneName)
    {
        switch (sceneName)
        {
            case "Splash":
                SceneManager.LoadScene(sceneName);
                break;

            case "MenuPrincipal":
                SceneManager.LoadScene(sceneName);
                ChangeState(GameState.MenuPrincipal);
                break;

            case "GetStarted_Scene":
                SceneManager.LoadScene(sceneName);

                SceneManager.LoadScene(
                    "GUI",
                    LoadSceneMode.Additive
                );
                
                ChangeState(GameState.Gameplay);
                break;

            default:
                Debug.LogWarning("Cena não reconhecida: " + sceneName);
                break;
        }
    }

    public void LoadMenu()
    {
        LoadScene("MenuPrincipal");
    }

    public void AssignPlayerInput(PlayerInput input)
    {
        playerInput = input;
        Debug.Log("PlayerInput alocado.");
=======
            return;
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += AoCarregarCena;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= AoCarregarCena;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Splash")
        {
            AtualizarEstadoPorCena("Splash");
            AlocarInput();
        }
        else
        {
            CarregarCena("Splash");
        }
    }

    public void CarregarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    private void AoCarregarCena(Scene cena, LoadSceneMode modo)
    {
        AtualizarEstadoPorCena(cena.name);
        AlocarInput();
    }

    private void AtualizarEstadoPorCena(string nomeCena)
    {
        if (nomeCena == "Splash")
        {
            MudarEstado(EstadoJogo.Iniciando);
        }
        else if (nomeCena == "Menu Principal")
        {
            MudarEstado(EstadoJogo.MenuPrincipal);
        }
        else if (nomeCena == "GetStarted_Scene")
        {
            MudarEstado(EstadoJogo.Gameplay);
            
            
            if (!SceneManager.GetSceneByName("GUI").isLoaded)
            {
                SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
            }
        }
    }

    public void MudarEstado(EstadoJogo novoEstado)
    {
        estadoAtual = novoEstado;
        Debug.Log("Estado atual alterado para: " + estadoAtual);
    }

    public void AlocarInput()
    {
        entradaJogador = FindFirstObjectByType<PlayerInput>();
        if (entradaJogador != null)
        {
            Debug.Log("Player Input encontrado na cena atual!");
        }
        else
        {
            Debug.Log("Nenhum Player Input encontrado nesta cena.");
        }
    }
    
  

    public void SairJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
>>>>>>> d8c0f6118bd357172b40678661437d93f191e297
    }
}