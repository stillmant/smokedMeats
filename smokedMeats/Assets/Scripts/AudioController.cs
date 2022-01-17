using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public OVRInput.Controller rightController;
    public OVRInput.Controller leftController;
    public AudioSource smokingTheseMeats;
    
    /* Mappings
     One = A
     Two = B
     Three = X
     Four = Y
     */

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One, rightController))
        {
            smokingTheseMeats.Play();
        }
    }
}
