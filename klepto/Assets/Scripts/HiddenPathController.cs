using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenPathController : MonoBehaviour
{
    Collider collider;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void enableCollider() {
        collider.enabled = true;
    }

    public void disableCollider() {
        collider.enabled = false;
    }
}
