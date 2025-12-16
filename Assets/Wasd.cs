using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasd : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed=5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
