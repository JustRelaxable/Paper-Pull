using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletPaperLongAI : ToiletPaperLong
{
    [SerializeField] float pullForDuration;
    [SerializeField] float waitForDuration;
    [SerializeField] ToiletPaperRollAI toiletPaperRollAI;

    private bool aiStarted = false;
    private void Update()
    {
        if (!aiStarted && Input.GetMouseButtonDown(0))
        {
            StartCoroutine(AIPull());
            aiStarted = true;
        }
    }

    private IEnumerator AIPull()
    {
        float time = 0f;
        while (!toiletPaperRipped)
        {
            toiletPaperRollAI.AudioSource.Play();
            while (time <= pullForDuration)
            {
                toiletPaperRollAI.RotateRoll();
                rigidbody.velocity = -transform.forward * pullSpeed;
                if (toiletPaperRipped)
                    StopAllCoroutines();
                time += Time.deltaTime;
                yield return null;
            }
            time = 0f;
            toiletPaperRollAI.AudioSource.Pause();
            while (time <= waitForDuration)
            {
                rigidbody.velocity = Vector3.zero;
                time += Time.deltaTime;
                yield return null;
            }
            time = 0f;
        }
    }
}
