using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("CookSurface"))
        {
            Debug.Log("We cooking");
        }
    }
}
