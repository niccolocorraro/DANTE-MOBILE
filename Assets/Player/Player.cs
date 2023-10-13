using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    public float speed;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     float horizontal = Input.GetAxis("Horizontal");
     float vertical = Input.GetAxis("Vertical");

     rigidbody.velocity = new Vector3(horizontal*speed, vertical*speed,0);   
    } 
    
}
