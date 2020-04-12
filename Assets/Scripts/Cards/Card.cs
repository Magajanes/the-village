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

    [SerializeField]
    protected CardInfo info;
    [SerializeField]
    protected InfoController controller;

    public void InitializeInfo()
    {
        controller.SetInfo(info);
    }

    public int GetPrice()
    {
        return info.Cost.Price;
    }

    [System.Serializable]
    public class Cost
    {
        [SerializeField]
        protected int coinCost;
        [SerializeField]
        protected int woodCost;
        [SerializeField]
        protected int stoneCost;
        [SerializeField]
        protected int ironCost;
        [SerializeField]
        protected int clayCost;
        [SerializeField]
        protected int plantCost;

        protected Dictionary<Resource.Category, int> resourceCost = new Dictionary<Resource.Category, int>();

        public int Price
        {
            get
            {
                return coinCost;
            }
        }

        public Dictionary<Resource.Category, int> ResourceCost
        {
            get
            {
                resourceCost.Add(Resource.Category.Wood, woodCost);
                resourceCost.Add(Resource.Category.Stone, stoneCost);
                resourceCost.Add(Resource.Category.Iron, ironCost);
                resourceCost.Add(Resource.Category.Clay, clayCost);
                resourceCost.Add(Resource.Category.Plant, plantCost);

                return resourceCost;
            }
        }
    }
}
