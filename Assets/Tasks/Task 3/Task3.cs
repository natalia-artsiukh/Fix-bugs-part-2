using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;
    
    private void Start()
    {
        var wall = _wallPrefab;
        wall.isKinematic = false;
        Instantiate(wall);
    }
}
