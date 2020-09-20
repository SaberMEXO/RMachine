using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followup : MonoBehaviour
{

    public Transform characterPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(characterPlayer.position.x, characterPlayer.position.y, transform.position.z);
    }
}
