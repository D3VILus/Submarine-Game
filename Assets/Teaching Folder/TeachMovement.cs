using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeachMovement : MonoBehaviour
{
    float Vspeed, Hspeed, Zspeed;
    float Timeie;


    // Start is called before the first frame update
    void Start()
    {
        Timeie = 15;
        Hspeed = 1;
        Vspeed = 1;
        Zspeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(transform.position.x - (Hspeed), transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(transform.position.x + (Hspeed), transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + (Vspeed), transform.position.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - (Vspeed), transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (Zspeed));
        }
        //Move backwards
        if (Input.GetKey(KeyCode.LeftControl))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (Zspeed));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Timeie = 15;
        Hspeed = -Hspeed;
        Vspeed = -Vspeed;
        Zspeed = -Zspeed;
        Debug.Log("Log");
    }

    private void FixedUpdate()
    {
        Timeie--;
        if(Timeie <= 0)
        {
            Hspeed = 1;
            Vspeed = 1;
            Zspeed = 1;
        }
    }


}