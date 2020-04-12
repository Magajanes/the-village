using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI namePanel;
    [SerializeField]
    private Image icon;
    [SerializeField]
    private TextMeshProUGUI costText;

    public void SetInfo(CardInfo info)
    {
        namePanel.text = info.Name;
        icon.sprite = info.Art;
        icon.preserveAspect = true;

        switch (info.Category)
        {
            case Card.Category.Item:
                costText.text = info.Cost.Price.ToString();
                break;

            default:
                break;
        }
    }

}
