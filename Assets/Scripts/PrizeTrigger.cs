using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeTrigger : MonoBehaviour
{
    bool prizeCollected = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!prizeCollected && other.CompareTag("PlayerGlass"))
        {
            GetComponent<AudioSource>().Play();
            prizeCollected = true;
        }
    }
}
