using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _capsule;
    [SerializeField] private float _smoothSpeed;
    
    void LateUpdate()
    {
        FollowCamera();
    }

    private void FollowCamera()
    {
        if (_capsule != null)
        {
            Vector3 targetPos = new Vector3(_capsule.position.x, _capsule.position.y, transform.position.z);
            
            transform.position = Vector3.Lerp(transform.position, targetPos, _smoothSpeed * Time.deltaTime);
        }
    }
}
