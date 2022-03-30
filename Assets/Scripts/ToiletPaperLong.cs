using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletPaperLong : MonoBehaviour
{
    protected Rigidbody rigidbody;
    protected Animator animator;
    [SerializeField] protected float pullSpeed;
    [SerializeField] protected Wobble liquidWobble;

    protected bool toiletPaperRipped = false;
    protected void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        liquidWobble.onToiletPaperRipped += () =>
        {
            animator.enabled = true;
            toiletPaperRipped = true;
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (toiletPaperRipped)
            return;

        if (Input.GetMouseButton(0))
        {
            rigidbody.velocity = -transform.forward * pullSpeed;
        }
        else
        {
            rigidbody.velocity = Vector3.zero;
        }
    }
}
