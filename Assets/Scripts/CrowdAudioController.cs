using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdAudioController : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] Wobble playerLiquid;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        playerLiquid.onToiletPaperRipped += PlayerLiquid_onToiletPaperRipped;
    }

    private void PlayerLiquid_onToiletPaperRipped()
    {
        audioSource.Play();
    }
}
