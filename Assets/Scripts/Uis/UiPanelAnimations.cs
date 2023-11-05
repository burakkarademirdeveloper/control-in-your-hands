using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UiPanelAnimations : MonoBehaviour
{
    [SerializeField] private GameObject _sliders;
    private bool _isPanelActive = false;
    
    public void SliderPanelAnimation()
    {
        Sequence sequence = DOTween.Sequence();
        if (!_isPanelActive)
        {
            sequence.Append(_sliders.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, -100), 0.5f));
            sequence.Append(_sliders.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, -50), .25f));
        }
        else
        {
            sequence.Append(_sliders.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, -100), .25f));
            sequence.Append(_sliders.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 100f), 0.5f));
        }
        _isPanelActive = !_isPanelActive;
    }
}
