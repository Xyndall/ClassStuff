using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public objBreak objDestroy = null;

    public LayerMask mask;

    float horizontal = 0;
    float vertical = 0;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(horizontal, 0, vertical);

        gameObject.transform.position += move * Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Debug.DrawRay(transform.position, transform.forward * 10, Color.magenta);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10, mask))
            {
                Debug.Log(hit.transform.name);
                //Destroy(gameObject);
                objDestroy.GetComponent<objBreak>().DestroyObj();
            }
        }

        

    }


}
