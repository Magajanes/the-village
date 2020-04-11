using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{
    [SerializeField]
    private ActionPlace place;

    private Hero visitor;
    private Coroutine entranceCoroutine;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        visitor = collider.GetComponent<Hero>();

        if (visitor == null)
            return;

        visitor.ToggleFeedback(InputFeedback.JUMP_BUTTON_NAME);

        if (entranceCoroutine == null)
            entranceCoroutine = StartCoroutine(AllowEntrance());
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        visitor.ToggleFeedback(InputFeedback.JUMP_BUTTON_NAME);

        if (entranceCoroutine != null)
        {
            StopCoroutine(entranceCoroutine);
            entranceCoroutine = null;
        }
    }

    private IEnumerator AllowEntrance()
    {
        while (true)
        {
            if (Input.GetButtonDown("Jump"))
                place.ReceiveGuest(visitor);

            yield return null;
        }
    }
}
