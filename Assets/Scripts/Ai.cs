using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    //AI
    NavMeshAgent agent = null;
    public float speed = 5;
    GameObject TargetPoint = null;

    //
    public LayerMask mask;
    public float raycastDist = 10;
    public GameObject hitTarget = null;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TargetPoint = new GameObject("TargetPoint");
        //hitTarget = TargetPoint;
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 direction = new Vector3(Mathf.Sin(Time.time), 0, 1);
        //agent.Move(direction * Time.deltaTime * speed);

        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * raycastDist, Color.magenta);
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDist, mask))
        {
            hitTarget = hit.transform.gameObject;
            
        }
        agent.SetDestination(hitTarget.transform.position);
    }


}
