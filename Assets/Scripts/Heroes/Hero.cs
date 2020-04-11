using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero : MonoBehaviour
{
    public enum Category
    {
        Warrior,
        Thief,
        Assassin,
        Wizard,
        Warlock,
        Climber,
        Ranger,
        Runner
    }

    [Header("Character Info")]
    [SerializeField]
    protected new string name;
    [SerializeField]
    protected Category category;
    [SerializeField]
    protected int level = 1;

    [Header("Current Stats")]
    [SerializeField]
    protected Weapon currentWeapon;
    [SerializeField]
    protected int currentCoinsAmount;

    [Header("References")]
    [SerializeField]
    protected InputFeedback inputFeedback;

    protected List<Item> inventory = new List<Item>();
    protected List<Objective> objectives = new List<Objective>();

    protected Dictionary<Resource.Category, int> wallet = new Dictionary<Resource.Category, int>()
    {
        {Resource.Category.Wood, 0 },
        {Resource.Category.Stone, 0 },
        {Resource.Category.Iron, 0 },
        {Resource.Category.Clay, 0 },
        {Resource.Category.Plant, 0 }
    };

    public int Coins
    {
        get
        {
            return currentCoinsAmount;
        }
    }

    public Dictionary<Resource.Category, int> Wallet
    {
        get
        {
            return wallet;
        }
    }

    //This is a debug method
    protected void ShowResources()
    {
        Debug.Log("Coins - " + currentCoinsAmount);

        foreach (var pair in wallet)
        {
            Debug.Log(pair.Key + " - " + pair.Value);
        }
    }

    //This is a debug method
    protected void ShowInventory()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Debug.Log((i + 1) + " - " + inventory[i].name);
        }
    }

    public void ToggleFeedback(string buttonName)
    {
        inputFeedback.ToggleFeedback(buttonName);
    }

    public bool CanBuy(ItemCard card)
    {
        return currentCoinsAmount >= card.Price;
    }

    public void Buy(ItemCard card)
    {
        currentCoinsAmount -= card.Price;
        inventory.Add(card.Item);
    }

    public abstract void Initialize();
}
