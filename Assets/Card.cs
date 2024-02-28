using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    private int value;
    private string suit;
    private Sprite image;


    public Card(int value, string suit, Sprite image)
    {
        this.value = value;
        this.suit = suit;
        this.image = image;
    }
    public Card(int value, string suit)
    {
        this.value = value;
        this.suit = suit;
    }

    public Sprite Image => image;

    public string Suit => suit;

    public int Value => value;
}
