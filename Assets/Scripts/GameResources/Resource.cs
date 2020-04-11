using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Resource
{
    public enum Category
    {
        Wood,
        Stone,
        Iron,
        Clay,
        Plant
    }

    public Category Type;
}
