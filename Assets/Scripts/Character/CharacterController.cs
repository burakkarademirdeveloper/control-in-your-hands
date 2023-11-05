using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    private bool _right = false;
    private bool _left = false;
    private bool _jump = false;
    
    private void Update()
    {
        gameObject.transform.localScale = new Vector3(ValueController.Instance.Scale, ValueController.Instance.Scale, 1);
        
        if (_right)
            gameObject.transform.Translate(Vector3.right * ValueController.Instance.Speed * Time.deltaTime);
        if (_left)
            gameObject.transform.Translate(Vector3.left * ValueController.Instance.Speed * Time.deltaTime);
    }
    public void Jump()
    {
        if (_jump)
        {
            _rb.AddForce(Vector2.up * ValueController.Instance.JumpForce, ForceMode2D.Impulse);
            _jump = false;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Ground>()) //String maliyetli olabileceğinden script kullanmayı tercih ediyorum.
        {
            _jump = true;
        }
    }
    
    public void MoveRight() => _right = true; 
    public void MoveLeft() => _left = true;
    public void StopMoveRight() => _right = false;
    public void StopMoveLeft() => _left = false;
}
