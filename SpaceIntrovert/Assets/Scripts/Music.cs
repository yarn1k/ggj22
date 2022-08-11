using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource party;

    public void ChangeMusic()
    {
        GetComponent<AudioSource>().enabled = false;
        party.Play(0);
    }
}
