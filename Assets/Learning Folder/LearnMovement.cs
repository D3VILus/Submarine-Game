using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMovement: MonoBehaviour
{
    float Vspeed, Hspeed, Zspeed;
    float Tminus;



    // Start is called before the first frame update
    void Start()
    {
        Hspeed = 1;
        Vspeed = 1;
        Zspeed = 1;
        Tminus = 15;
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
        if (Input.GetKey(KeyCode.LeftControl))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (Zspeed));
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Tminus = 15;
        Hspeed = -Hspeed;
        Vspeed = -Vspeed;
        Zspeed = -Zspeed;

        Debug.Log("Log enter");
    }
    //void OnTriggerExit(Collider other)
  //  {
       // Debug.Log("Log exit");
//    }
    void FixedUpdate()
    {
        Debug.Log(Tminus);
        Tminus --;
        if (Tminus <= 0)
        {  
         Hspeed = 1;
         Vspeed = 1;
         Zspeed = 1;
        }
    }


// OnTriggerStay Check tag = look it up destroy mine debug log so make a score








































}
