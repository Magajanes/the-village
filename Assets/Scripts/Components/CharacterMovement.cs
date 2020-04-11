using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody2D heroRigidbody;

    private Vector3 direction;

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        direction.z = 0;

        direction = direction.magnitude > 1 ? direction.normalized : direction;
        heroRigidbody.velocity = direction * speed;
    }
}
