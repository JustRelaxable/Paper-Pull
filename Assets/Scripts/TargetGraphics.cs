using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGraphics : MonoBehaviour
{
    [SerializeField] int targetFramerate = 30;

    private void Awake()
    {
        Application.targetFrameRate = targetFramerate;
    }
}
