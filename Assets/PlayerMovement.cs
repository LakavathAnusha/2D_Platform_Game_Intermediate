using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX=Input.GetAxis("Horizontal")*playerSpeed;
        if (inputX > 0.01)
        {
            transform.Translate(new Vector3(inputX, transform.position.y, transform.position.z));
        }
        else
        {
            transform.Translate(new Vector3(inputX, transform.position.y, transform.position.z));
        }
    }
}
