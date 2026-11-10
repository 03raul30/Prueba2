using System;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;
    [SerializeField] Transform platform;


    private void Start()
    {
        
        Vector2 horizontalDirection = (target.position - transform.position).normalized;
        horizontalDirection.y = 0;
        
        
        
    }
}