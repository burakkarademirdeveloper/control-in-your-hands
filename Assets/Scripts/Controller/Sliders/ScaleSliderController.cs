using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScaleSliderController : MonoBehaviour
{
    private Slider _slider;
    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        ValueController.Instance.Scale = _slider.value;
    }

    private void Start()
    {
        _slider.value = ValueController.Instance.Scale;
    }
}
