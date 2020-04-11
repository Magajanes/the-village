using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{
    [SerializeField]
    private GameObject transporterPrefab;

    private GameObject selectedHero;
    public static PrefabTransporter Transporter;

    private void Start()
    {
        CreateTransporter();
    }

    private void CreateTransporter()
    {
        if (Transporter != null)
            return;

        if (Transporter == null)
        {
            Transporter = Instantiate(transporterPrefab).GetComponent<PrefabTransporter>();
        }
    }

    public void SelectCharacter(GameObject heroPrefab)
    {
        selectedHero = heroPrefab;
        Debug.Log(selectedHero.name);
    }

    public void ChooseSelectedHero()
    {
        if (selectedHero == null)
            return;

        var hero = Instantiate(selectedHero);
        hero.transform.SetParent(Transporter.transform);
        Transporter.SetHero(hero);

        MainMenu.LoadScene("Main");
    }
}
