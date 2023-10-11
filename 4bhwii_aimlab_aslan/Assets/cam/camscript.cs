using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camscript : MonoBehaviour
{
    public float mouseyspeed = 0;
    [Range(0f, 90f)]
    public float yroationlimit = 88f;
    private Vector2 camRotation = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float vertmouseinput = Input.GetAxis("Mouse Y");
        camRotation.y += vertmouseinput *mouseyspeed * Time.deltaTime *60;
        camRotation.y = Mathf.Clamp(camRotation.y, -yroationlimit, yroationlimit);
        var yQuat = Quaternion.AngleAxis(camRotation.y, Vector3.left);
        transform.localRotation = yQuat;

    }
}
