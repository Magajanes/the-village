using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ResourceLoot
{
    [SerializeField]
    private Resource resource;
    [SerializeField]
    private int amount;

    public Resource.Category GetResourceType()
    {
        return resource.Type;
    }

    public int GetAmount()
    {
        return amount;
    }
}
