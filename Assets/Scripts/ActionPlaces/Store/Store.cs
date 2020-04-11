using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : ActionPlace
{
    [SerializeField]
    private StorePanel panel;

    private Hero visitor;
    private ItemCard[] cardsForSale;

    public override void ReceiveGuest(Hero hero)
    {
        visitor = hero;

        panel.gameObject.SetActive(true);
        cardsForSale = panel.SetCards();
        panel.Open();
    }

    public void SelectCard(int index)
    {
        //Show card details
        //Enable purchase button if hero can buy card
    }

    public void SellCard(int index)
    {
        visitor.Buy(cardsForSale[index]);
    }
}
