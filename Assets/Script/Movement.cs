using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.D))transform.position +=Vector3.right * movementSpeed * Time.deltaTime;
      if(Input.GetKey(KeyCode.A))transform.position +=Vector3.left  * movementSpeed * Time.deltaTime;
    }

   
}
