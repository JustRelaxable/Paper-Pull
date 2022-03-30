using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletPaperRollAI : ToiletPaperRoll
{
    public AudioSource AudioSource { get => audioSource; }
    public void RotateRoll()
    {
        transform.RotateAround(Vector3.right, rollSpeed * Time.deltaTime);
    }

    private void Update()
    {
        
    }
}
