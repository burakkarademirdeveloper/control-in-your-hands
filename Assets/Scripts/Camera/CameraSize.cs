using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CameraSize : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _capsuleRigi;
    private void Awake()
    {
        CameraSizeChange();
    }
    
    private void CameraSizeChange()
    {
        Camera.main.orthographicSize = 0.1f;
        Camera.main.DOOrthoSize(5f, 2f).OnComplete((() => _capsuleRigi.simulated = true));
    }
}
