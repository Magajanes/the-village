using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public enum Category
    {
        Assault,
        Stealth,
        Explore
    }

    private Category category;
    private int level;
    private Objective objective;
    private Reward reward;
}
