using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherTrigger)
    {
        Destroy(otherTrigger.gameObject); //Game Object del animal
        Destroy(gameObject); //Game Object del proyectil
    }
}
