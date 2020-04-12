using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorePanel : MonoBehaviour
{
    [SerializeField]
    private GameObject cardPrefab;
    [SerializeField]
    private Transform[] cardSlots = new Transform[5];

    public ItemCard[] SetCards()
    {
        var cards = new List<ItemCard>();

        foreach (var slot in cardSlots)
        {
            var card = Instantiate(cardPrefab).GetComponent<ItemCard>();

            cards.Add(card);
            card.transform.SetParent(slot);
            card.transform.localPosition = Vector3.zero;
            card.InitializeInfo();
        }

        return cards.ToArray();
    }

    public void Open()
    {

    }


}
