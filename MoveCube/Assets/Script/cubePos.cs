using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class cubePos : MonoBehaviour
{

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.speed = 2;
                agent.SetDestination(hit.point);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            agent.speed = 0;
        }
    }
}
