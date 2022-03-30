using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIKAnimationController : MonoBehaviour
{
    Animator ikAnimator;
    [SerializeField] Wobble liquidWobble;
    private bool toiletPaperRipped = false;

    private void Awake()
    {
        ikAnimator = GetComponent<Animator>();
        liquidWobble.onToiletPaperRipped += () => toiletPaperRipped = true;
    }

    private void Update()
    {
        if (toiletPaperRipped)
        {
            ikAnimator.SetFloat("RollSpeed", 0);
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            ikAnimator.SetFloat("RollSpeed", 1);
        }
        if (Input.GetMouseButtonUp(0))
        {
            ikAnimator.SetFloat("RollSpeed", 0);
        }
    }
}
