using UnityEngine;
using UnityEngine.UI;
public class JumpSliderController : MonoBehaviour
{
    private Slider _slider;
    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        ValueController.Instance.JumpForce = _slider.value;
    }

    private void Start()
    {
        _slider.value = ValueController.Instance.JumpForce;
    }
}
