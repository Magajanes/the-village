using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform heroAnchor;
    [SerializeField]
    private ResourcePanel resourcePanel;

    [SerializeField]
    private GameObject testHero;

    void Start()
    {
        GameObject heroPrefab = null;

        if (PrefabManager.Transporter != null)
            heroPrefab = PrefabManager.Transporter.GetHero();

        if (heroPrefab == null)
            heroPrefab = Instantiate(testHero);

        heroPrefab.transform.SetParent(heroAnchor, true);

        var hero = heroPrefab.GetComponent<Hero>();
        hero.Initialize();

        resourcePanel.CreateDictionary();
        resourcePanel.SetCoinsPanel(hero.Coins);
        resourcePanel.SetResourcesPanel(hero.Wallet);
    }
}
