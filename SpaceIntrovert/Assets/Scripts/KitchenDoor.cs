using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenDoor : MonoBehaviour
{
    public Animator door;
    public static bool isAccess = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isAccess)
        {
            door.SetBool("character_nearby", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        door.SetBool("character_nearby", false);
    }
}
