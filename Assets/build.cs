using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour
{
    public GameObject thecamera;
    public GameObject create;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButton(1)) // detecting right clicks
        {
            RaycastHit hit; // output parameter in physics raycast
            //refers to camera component on the game object
            Ray ray = thecamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition); 
            // after doing raycast, hit contains info
        if(Physics.Raycast(ray, out hit, Mathf.Infinity)) 
        {
            GameObject.Instantiate(create, hit.point, Quaternion.identity);
        }
        }
    }
}
