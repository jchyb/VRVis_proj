using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateByInput : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        var speed = 50; 
        if(Gamepad.current == null) return;
        var rotation = Gamepad.current.leftStick.ReadValue();
        gameObject.transform.Rotate(
            rotation.y * speed * Time.deltaTime,
            rotation.x * speed * Time.deltaTime,
            0,
            Space.World
        );
        // gameObject.transform.rotation = Quaternion.LookRotation(
        //     rotation.x * speed * Time.deltaTime,
        //     rotation.y * speed * Time.deltaTime
        // );

    }
}
