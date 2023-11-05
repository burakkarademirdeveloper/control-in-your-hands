using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rb;

    private bool _right = false;
    private bool _left = false;
    private bool _jump = false;
    
    private void Update()
    {
        if (_right)
            gameObject.transform.Translate(Vector3.right * _speed * Time.deltaTime);
        if (_left)
            gameObject.transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
    public void Jump()
    {
        if (_jump)
        {
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _jump = false;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Ground>())
        {
            _jump = true;
            Debug.Log(other.gameObject.name);
        }
    }
    
    public void MoveRight() => _right = true; 
    public void MoveLeft() => _left = true;
    public void StopMoveRight() => _right = false;
    public void StopMoveLeft() => _left = false;
}
