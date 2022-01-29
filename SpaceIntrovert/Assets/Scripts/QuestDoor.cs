using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDoor : MonoBehaviour
{
    public Animator door;

    private void OnTriggerEnter(Collider other)
    {
        door.SetBool("character_nearby", true);
    }

    private void OnTriggerExit(Collider other)
    {
        door.SetBool("character_nearby", false);
    }
}
