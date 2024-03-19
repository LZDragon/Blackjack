using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Deck gameDeck;

    private Player mainPlayer;
    [SerializeField] private GameObject displayCardPrefab;
    [SerializeField] private GameObject playerDisplayPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        gameDeck = new Deck();
        mainPlayer = new Player("Steve");
        DealStartingHand(2);
    }

    void DealStartingHand(int startingHandSize)
    {
        for (int i = startingHandSize; i > 0; i++)
        {
            mainPlayer.TakeCard(gameDeck.DrawFromDeck());
        }
    }

    void CheckForBust(Player player)
    {
        if (player.EvaluateHand() > 21)
        {
            Debug.Log("Game Over");
        }
    }
}
