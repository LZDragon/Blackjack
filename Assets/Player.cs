

using System.Collections.Generic;

public class Player
{
    private string name;
    private List<Card> hand;
    private bool continuePlaying;
    private int handValue;
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
    
}
