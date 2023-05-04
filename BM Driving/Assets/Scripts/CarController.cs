using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float turnSpeed = 0.5f;
    private float turnDirection = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(0f, turnSpeed * turnDirection * Time.deltaTime,0f);
    }

    public void Turn(float direction) 
    {
        Debug.Log(direction);
        turnDirection = direction;
    }
}
