using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSpeedSliderController : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    private Slider _slider;
    private void Awake()
    {
        _slider = _gameObject.GetComponent<UnityEngine.UI.Slider>();
    }

    private void Update()
    {
        ValueController.Instance.Speed = _slider.value;
    }

    private void Start()
    {
        _slider.value = ValueController.Instance.Speed;
    }
}
