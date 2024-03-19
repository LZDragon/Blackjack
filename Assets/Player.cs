

using System.Collections.Generic;

public class Player
{
    protected List<Card> hand = new List<Card>();
    protected bool continuePlaying;

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
