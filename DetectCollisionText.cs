using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //if object collide then destroy 2 collide object. after that game over
        Debug.Log("Game Over!"); 
        Destroy(gameObject);
        Destroy(other.gameObject);
        Application.Quit();
    }
}
