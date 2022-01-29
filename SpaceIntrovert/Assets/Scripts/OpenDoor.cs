using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject chip;
    public Animator door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            chip.SetActive(false);
            door.SetBool("character_nearby", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        door.SetBool("character_nearby", false);
        chip.SetActive(true);
    }
}
