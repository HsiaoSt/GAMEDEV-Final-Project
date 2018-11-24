using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystemScript : MonoBehaviour {

    private readonly float maxDistance = 10f;
    private Ray ray;
    private RaycastHit hit;

	// Use this for initialization
	void Start () {
        ray = new Ray(gameObject.transform.position, transform.TransformDirection(Vector3.forward));
        //ray = this.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
    }

// Update is called once per frame
    void Update() {
        //Debug.DrawRay(gameObject.transform.position, transform.TransformDirection(Vector3.forward), Color.red);

        if(Physics.Raycast(ray, out hit, maxDistance))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
        else
        {
            Debug.Log("Not hitting anything.");
        }
    }
}
