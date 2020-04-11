using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public enum Category
    {
        Item,
        Objective
    }

    public CardInfo Info;

    public class Cost
    {
        protected int coinCost;
        protected int woodCost;
        protected int stoneCost;
        protected int ironCost;
        protected int clayCost;
        protected int plantCost;
    }

    public class CoinCost : Cost
    {
        public int Price
        {
            get
            {
                return coinCost;
            }
        }

        public CoinCost(int price)
        {
            coinCost = price;
        }
    }

    public class ResourceCost : Cost
    {
        public Dictionary<Resource.Category, int> Cost { get; } = new Dictionary<Resource.Category, int>();

        public ResourceCost(int wood, int stone, int iron, int clay, int plant)
        {
            Cost.Add(Resource.Category.Wood, wood);
            Cost.Add(Resource.Category.Stone, stone);
            Cost.Add(Resource.Category.Iron, iron);
            Cost.Add(Resource.Category.Clay, clay);
            Cost.Add(Resource.Category.Plant, plant);
        }
    }
}
