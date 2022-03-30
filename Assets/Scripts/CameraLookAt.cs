using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraLookAt : MonoBehaviour
{
    [SerializeField] Transform cameraLookTransform;
    [SerializeField] Transform cameraDefaultLook;
    [SerializeField] Transform cameraOpponentLook;

    [SerializeField] Wobble liquidWobble;
    private bool toiletPaperRipped = false;

    private void Awake()
    {
        liquidWobble.onToiletPaperRipped += LiquidWobble_onToiletPaperRipped;
    }

    private void LiquidWobble_onToiletPaperRipped()
    {
        toiletPaperRipped = true;
    }

    private void Update()
    {
        if (toiletPaperRipped)
        {
            cameraLookTransform.DOMove(cameraDefaultLook.position, 1);
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            cameraLookTransform.DOMove(cameraDefaultLook.position, 1);
        }
        if (Input.GetMouseButtonUp(0))
        {
            cameraLookTransform.DOMove(cameraOpponentLook.position, 1);
        }
    }
}
