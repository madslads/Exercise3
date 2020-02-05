using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinMan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	if (Input.GetButton("Fire1")) 
	{
	 this.transform.Rotate(0.0f, 5.0f, 0.0f);
	}

    }
}
