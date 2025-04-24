using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScriptControllerE : MonoBehaviour
{
    public bool kill;
    public bool dead;
    void Awake()
    {
        if (gameObject.tag == "Suspect")
        {
            kill = false;
        }
        else {
            kill = true;
        }

        dead = false;
    }

    // Update is called once per frame
    void Start()
    {
        if (!kill)
        {
            this.GetComponent<MurderController>().enabled = false;
            this.GetComponent<BodyController>().enabled = false;
            StopAllCoroutines();
        }
        else {
            this.GetComponent<EController>().enabled = false;
            this.GetComponent<BodyController>().enabled = false;
            StopAllCoroutines();
        }

    }

    private void FixedUpdate()
    {
        if (gameObject.tag == "Untagged")
        {
            this.GetComponent<MurderController>().enabled = true;
            this.GetComponent<EController>().enabled = false;
            this.GetComponent<BodyController>().enabled = false;
            StopAllCoroutines();
        }

        if (gameObject.tag == "KilledSuspect")
        {
            dead = true;
        }

        if (dead)
        {
            this.GetComponent<EController>().enabled = false;
            this.GetComponent<BodyController>().enabled = true;
            this.GetComponent<NavMeshAgent>().enabled = false;
            StopAllCoroutines();
        }
    }
}
