using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UiPanelAnimations : MonoBehaviour
{
    [SerializeField] private RectTransform _sliders;
    private bool _isPanelActive = false;
    private float _initialPosY;

    private void Start()
    {
        _initialPosY = _sliders.anchoredPosition.y;
    }

    public void SliderPanelAnimation() 
    {
        Sequence sequence = DOTween.Sequence();
        if (!_isPanelActive)
        {
            sequence.Append(_sliders.DOAnchorPos(new Vector2(0, (-_initialPosY - 100f)), 0.5f));
            sequence.Append(_sliders.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, -_initialPosY), .25f));
        }
        else
        {
            sequence.Append(_sliders.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, (-_initialPosY - 100)), .25f));
            sequence.Append(_sliders.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, _initialPosY), 0.5f));
        }
        _isPanelActive = !_isPanelActive;
    }
}
