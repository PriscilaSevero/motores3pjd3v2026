using UnityEngine;
using TMPro;
using StarterAssets;
using UnityEngine.InputSystem;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text player1CoinText;
    [SerializeField] private TMP_Text player2CoinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCountChanged += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCountChanged -= UpdateCoins;
    }

    private void UpdateCoins(ThirdPersonController player, int amount)
    {
        if (player == null)
            return;

        PlayerInput playerInput = player.GetComponent<PlayerInput>();

        if (playerInput == null)
            return;

        if (playerInput.defaultActionMap == "Player 1")
        {
            player1CoinText.text = "Jogador 1: " + amount;
        }
        else if (playerInput.defaultActionMap == "Player 2")
        {
            player2CoinText.text = "Jogador 2: " + amount;
        }
    }
}