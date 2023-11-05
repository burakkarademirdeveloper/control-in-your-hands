using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class ValueController : MonoBehaviour
{
    [Range(4f,15f)] public float Speed;
    [Range(3f,15f)] public float JumpForce;
    [Range(.25f,3f)] public float Scale;
    
    
    
    
    public static ValueController Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }
}
