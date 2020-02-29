using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public triggerZone HandLeft;
    public triggerZone HandRight;

    public DragonAI dragon;

    public Rigidbody rb;

    public Transform testObject;

    // Start is called before the first frame update
    void Start()
    {
        HandLeft.onTriggerStay += grabIntersection;
        HandRight.onTriggerStay += grabIntersection;
        //print("start");

        rb = transform.root.GetComponent<Rigidbody>();
    }

    void grabIntersection(Collider other)
    {
        print("collision " + other.gameObject.name);
        //other.
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 handFull = new Vector3(.2f, .2f, .2f);
        Vector3 handGrip = new Vector3(.2f, .2f, .2f);

        if (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) > .5f) HandLeft.transform.localScale = handGrip;
        else HandLeft.transform.localScale = handFull;

        if (OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > .5f) HandRight.transform.localScale = handGrip;
        else HandRight.transform.localScale = handFull;

        if (OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).magnitude > .2f && OVRInput.Get(OVRInput.RawAxis2D.RTouchpad).magnitude > .2f) 
            transform.root.Rotate(0, 0, 10);

        rb.MovePosition(testObject.position);
        rb.useGravity = false;

    }
}
