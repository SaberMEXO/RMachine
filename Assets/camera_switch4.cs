using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_switch4 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camera1;
    public Camera camera2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D ball)
    {
        print("camera4 siwtched");
        camera1.enabled = false;
        camera2.enabled = true;
    }
}
