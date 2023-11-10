using UnityEngine;
using UnityEngine.UI;

public class MoveSpeedSliderController : MonoBehaviour
{
    private Slider _slider;
    private void Awake()
    {
        _slider = GetComponent<Slider>();
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
