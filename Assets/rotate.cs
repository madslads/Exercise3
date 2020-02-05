using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
	public float rotate_speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
// this refers to object in class being defined
// transform referring to transform component
        this.transform.Rotate(0, rotate_speed, 0);   // vector 3 eulers
    }
}
