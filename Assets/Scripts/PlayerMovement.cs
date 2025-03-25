using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.D)){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.25f, 0));
        }
        
        if (Input.GetKey(KeyCode.A)){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.25f, 0));
        }

        if (Input.GetKey(KeyCode.W)){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0.25f));
        }

        if (Input.GetKey(KeyCode.S)){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -0.25f));
        }
    }
}
