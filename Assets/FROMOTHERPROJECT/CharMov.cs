using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMov : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 12f;
    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 move = transform.forward*-1;
            controller.Move(move*speed*Time.deltaTime);
        }
                if (Input.GetKey(KeyCode.S))
        {
            Vector3 move = transform.forward*1;
            controller.Move(move*speed*Time.deltaTime);
        }
                if (Input.GetKey(KeyCode.Space))
        {
            Vector3 move = transform.up*1;
            controller.Move(move*speed*Time.deltaTime);
        }
                if (Input.GetKey(KeyCode.LeftControl))
        {
            Vector3 move = transform.up*-1;
            controller.Move(move*speed*Time.deltaTime);
        }
               //               if (Input.GetKey(KeyCode.A))
                //{Vector3 rotationVector = new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z-0.1f);
                 //   transform.localRotation =Quaternion.Euler(rotationVector);
                //}
                  //              if (Input.GetKey(KeyCode.D))
                //{Vector3 rotationVector = new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z+0.1f);
                  //  transform.localRotation =Quaternion.Euler(rotationVector);
                //}
               
                

    }

}

