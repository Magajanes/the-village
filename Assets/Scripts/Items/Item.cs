using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    protected new string name;
    [SerializeField]
    protected int priceToSell;

    public int GetPrice()
    {
        return priceToSell;
    }
}
