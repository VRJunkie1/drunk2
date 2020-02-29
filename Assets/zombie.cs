using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        //foreach (Transform tf in transform) {
            //nav = tf.GetComponent<NavMeshAgent>();
            nav = GetComponent<NavMeshAgent>();
        //   if (nav != null) break;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //print(nav);
        nav.SetDestination(player.position);
    }
}
