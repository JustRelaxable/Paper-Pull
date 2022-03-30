using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletPaperRoll : MonoBehaviour
{
    [SerializeField] protected float rollSpeed;
    [SerializeField] protected Wobble liquidWobble;
    protected AudioSource audioSource;

    protected bool toiletPaperRipped = false;
    protected void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        liquidWobble.onToiletPaperRipped += () =>
        {
            toiletPaperRipped = true;
            audioSource.Stop();
        };
    }

    private void Update()
    {
        if (toiletPaperRipped)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            audioSource.Pause();
        }

        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(Vector3.right, rollSpeed * Time.deltaTime);
        }
    }
}
