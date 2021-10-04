using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    public LayerMask mask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Debug.DrawRay(transform.position, transform.forward * 10, Color.magenta);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10, mask))
            {
                Debug.Log(hit.transform.name);
            }
        }

        

    }


}
