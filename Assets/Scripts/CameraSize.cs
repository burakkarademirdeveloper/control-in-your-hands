using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CameraSize : MonoBehaviour
{
    private void Awake()
    {
        CameraSizeChange();
    }
    
    private void CameraSizeChange()
    {
        Camera.main.DOOrthoSize(5f, 2f);
    }
}
