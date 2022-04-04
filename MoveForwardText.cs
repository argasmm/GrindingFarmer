using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardText : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move object forward, in this case food and animal
        transform.Translate(Vector3.down * Time.deltaTime * speed);



    }
}
