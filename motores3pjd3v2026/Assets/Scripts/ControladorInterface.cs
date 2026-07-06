using UnityEngine;
using TMPro;

public class ControladorInterface : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoMoedas;

    private void OnEnable()
    {
        PlayerObserverManager.OnMoedasAlteradas += AtualizarTextoMoedas;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnMoedasAlteradas -= AtualizarTextoMoedas;
    }
    

    private void AtualizarTextoMoedas(int quantidade)
    {
        if (textoMoedas != null)
        {
            textoMoedas.text = $"Moedas {quantidade}";
        }
    }
}