using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck
{
    private Stack<Card> stack = new Stack<Card>(52);
    private Sprite[] allCardsSprites;

    public Deck()
    {
        allCardsSprites = Resources.LoadAll<Sprite>("CardDeck");
        GenerateDeck();
    }

    public Card DrawFromDeck()
    {
        Card drawnCard = stack.Pop();
        return drawnCard;
    }
    
    void Shuffle<T>(ref List<T> OutList)
    {
        OutList = OutList.OrderBy(x=>System.DateTime.Now.Second ).ToList();
    }

    void GenerateDeck()
    {
        int imageIndex = 0;
        Card generatedCard;
        int cardValue = 0;
        List<Card> cachedDeck = new List<Card>(52);
        for (int suit = 0; suit < 4; suit++)
        {
            for (int i = 14; i > 1; i--) //Lines up with sprite sheet
            {
                if (i > 10) //Face card
                {
                    if (i == 14)//Ace
                    {
                        //implement ace
                        cardValue = 1;
                    }
                    else
                    {
                        cardValue = 10;
                    }
                }
                else
                {
                    cardValue = i;
                }
                generatedCard = new Card(cardValue, suit.ToString(), allCardsSprites[imageIndex]);
                cachedDeck.Add(generatedCard);
                imageIndex++;
            }
        }
        Shuffle(ref cachedDeck);
        foreach (var cachedCard in cachedDeck)
        {
            stack.Push(cachedCard);
        }
        Debug.Log(stack.Count);
    }
}
