﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushWallTrigger : MonoBehaviour {

    public static bool Triggered = false;

    //Used to determine when the object has entered the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        /*
        Determines if the object that has entered the zone has 
        the "PushWall" tag and therefore if it can trigger a the wall push
        */
        if (other.gameObject.tag == "Ball")
        {

            Triggered = true;

        }
    }

}
