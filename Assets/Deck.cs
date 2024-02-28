using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck
{
    private List<Card> stack;
    private int amountDrawn;

    public Deck()
    {
        GenerateDeck();
        Shuffle();
    }

    Card Draw()
    {
        Card drawnCard = stack[amountDrawn];
        amountDrawn++;
        return drawnCard;
    }

    void Shuffle()
    {
        stack = stack.OrderBy(x=>System.DateTime.Now.Second ).ToList();
        amountDrawn = 0;
    }

    void GenerateDeck()
    {
        int imageIndex = 0;
        for (int suit = 0; suit < 4; suit++)
        {
            for (int i = 14; i > 1; i--) //Lines up with sprite sheet
            {
                if (i > 10) //Face card
                {
                    if (i == 14)//Ace
                    {
                        //implement ace
                        stack.Add(new Card(1, suit.ToString()));
                    }
                    else
                    {
                        stack.Add(new Card(10,suit.ToString()));
                    }
                }
                else
                {
                    stack.Add(new Card(i,suit.ToString()));
                }

                imageIndex++;
            }
        }
    }
}
