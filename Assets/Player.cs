

using System.Collections.Generic;

public class Player
{
    private string name;
    private List<Card> hand = new List<Card>();
    private bool continuePlaying;
    private int handValue;

    public Player(string name)
    {
        this.name = name;
    }
    
    public List<Card> Hand => hand;
    public bool ContinuePlaying
    {
        get => continuePlaying;
        set => continuePlaying = value;
    }

    public int EvaluateHand()
    {
        int total = 0;
        foreach (var card in hand)
        {
            total += card.Value;
        }
        return total;
    }

    public void TakeCard(Card obtainedCard)
    {
        hand.Add(obtainedCard);
        EvaluateHand();
    }
}
