using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public float speed = 0;
    public float mousexspeed = 0;
    public float jumpHeight = 0;
    Rigidbody ridgid;
    // Start is called before the first frame update
    void Start()
    {
        ridgid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        float mouseInput = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseInput * mousexspeed , 0);
        transform.position += transform.forward * verticalInput * speed;
        transform.position += transform.right * horizontalInput*speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ridgid.AddForce(Vector3.up * jumpHeight);
        }
    }
}
