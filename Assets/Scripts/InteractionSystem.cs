using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionSystem : MonoBehaviour {

    private readonly float maxDistance = 3f;
    private Ray ray;
    private RaycastHit hit;

    private GameObject interactable;
    private Text intText;

	// Use this for initialization
	void Start () {
        intText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update() {
        ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            interactable = hit.collider.gameObject;

            if (interactable.tag == "Interactable")
            {
                //Debug.Log("Interactable object - " + interactable.name);
                intText.enabled = true;
                intText.text = interactable.GetComponent<Interactable>().actionText;

                if (Input.GetMouseButtonDown(0))
                {

                }
            }
        }
        else
        {
            //Debug.Log("Not hitting anything.");

            intText.enabled = false;
        }
    }
}
