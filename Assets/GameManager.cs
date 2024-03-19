using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Deck gameDeck;

    private Player mainPlayer;
    private House computer;
    [SerializeField] private GameObject displayCardPrefab;
    [SerializeField] private GameObject playerDisplayPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        gameDeck = new Deck();
        mainPlayer = new Player();
        DealStartingHand(2);
    }

    void DealStartingHand(int startingHandSize)
    {
        for (int i = startingHandSize; i > 0; i++)
        {
            mainPlayer.TakeCard(gameDeck.DrawFromDeck());
        }
    }

    void OnHitButtonClick()
    {
        DistributeCards();
    }
    
    

    void DistributeCards()
    {
        if (mainPlayer.ContinuePlaying && mainPlayer.Hand.Count <= 5)
        {
            mainPlayer.TakeCard(gameDeck.DrawFromDeck());
        }

        if (computer.ContinuePlaying && computer.Hand.Count <= 5)
        {
            computer.TakeCard(gameDeck.DrawFromDeck());
        }
    }
    void CheckForBust(Player player)
    {
        if (player.EvaluateHand() > 21)
        {
            Debug.Log("Game Over");
        }
    }

    void CompareHandScores()
    {
        int mainPlayerScore = mainPlayer.EvaluateHand();
        int computerScore = computer.EvaluateHand();
        if (mainPlayerScore > computerScore)
        {
            Debug.Log("Player Wins");
        }
        else if (mainPlayerScore == computerScore)
        {
            Debug.Log("Blackjack");
        }
        else
        {
            Debug.Log("Player Loses");
        }
    }
    
    
    
    
}
