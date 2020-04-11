using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTransporter : MonoBehaviour
{
    private GameObject selectedHero;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SetHero(GameObject selectedHero)
    {
        this.selectedHero = selectedHero;
    }

    public GameObject GetHero()
    {
        return selectedHero;
    }
}
