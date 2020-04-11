using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    [SerializeField]
    private List<ResourceLoot> breakResources = new List<ResourceLoot>();
    [SerializeField]
    private float damageBonus;
}
