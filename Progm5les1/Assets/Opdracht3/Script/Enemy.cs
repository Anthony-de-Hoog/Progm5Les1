using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f; 

    void Update()
    {
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}