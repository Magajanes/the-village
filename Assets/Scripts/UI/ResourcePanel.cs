using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourcePanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coinsAmountText;
    [SerializeField]
    private TextMeshProUGUI[] resourceAmountTexts = new TextMeshProUGUI[5];

    private Dictionary<Resource.Category, TextMeshProUGUI> resources = 
        new Dictionary<Resource.Category, TextMeshProUGUI>();

    public void CreateDictionary()
    {
        resources.Add(Resource.Category.Wood, resourceAmountTexts[0]);
        resources.Add(Resource.Category.Stone, resourceAmountTexts[1]);
        resources.Add(Resource.Category.Iron, resourceAmountTexts[2]);
        resources.Add(Resource.Category.Clay, resourceAmountTexts[3]);
        resources.Add(Resource.Category.Plant, resourceAmountTexts[4]);
    }

    public void SetCoinsPanel(int amount)
    {
        coinsAmountText.text = amount.ToString();
    }

    public void SetResourcesPanel(Dictionary<Resource.Category, int> wallet)
    {
        foreach (var pair in wallet)
        {
            resources[pair.Key].text = pair.Value.ToString();
        }
    }
}
