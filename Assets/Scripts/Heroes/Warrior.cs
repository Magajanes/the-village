using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Hero
{
    [Header("Initial Stats")]
    [SerializeField]
    private int initialCoinsAmount;
    [SerializeField]
    private Weapon initialWeapon;
    [SerializeField]
    private List<ResourceLoot> initialResources;

    public override void Initialize()
    {
        inputFeedback.Initialize();

        currentCoinsAmount = initialCoinsAmount;
        currentWeapon = initialWeapon;
        inventory.Add(currentWeapon);

        foreach (var loot in initialResources)
        {
            wallet[loot.GetResourceType()] += loot.GetAmount();
        }

        ShowResources();
    }
}
