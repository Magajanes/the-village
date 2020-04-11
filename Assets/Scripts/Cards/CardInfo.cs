using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Info", menuName = "Card Info", order = 0)]
public class CardInfo : ScriptableObject
{
    public Card.Category Category;
    public string Name;
    public string Description;
    public Sprite Art;
    public Card.Cost Cost;
}
