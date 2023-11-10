using UnityEngine;

public class ValueController : MonoBehaviour
{
    [Range(4f,15f)] public float Speed;
    [Range(3f,15f)] public float JumpForce;
    [Range(.25f,3f)] public float Scale;
    
    
    public static ValueController Instance; //Singleton

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
