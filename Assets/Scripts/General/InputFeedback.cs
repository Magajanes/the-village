using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFeedback : MonoBehaviour
{
    public const string JUMP_BUTTON_NAME = "Jump";

    [SerializeField]
    private GameObject YButtonFeedbackPrefab;

    private GameObject activeFeedback;
    private Dictionary<string, GameObject> buttons = new Dictionary<string, GameObject>();

    public void Initialize()
    {
        var yButton = Instantiate(YButtonFeedbackPrefab);

        yButton.transform.SetParent(transform);
        yButton.gameObject.SetActive(false);

        buttons.Add(JUMP_BUTTON_NAME, yButton);
    }

    public void ToggleFeedback(string name)
    {
        var button = buttons[name];
        var active = button.activeInHierarchy;

        button.SetActive(!active);
    }
}
