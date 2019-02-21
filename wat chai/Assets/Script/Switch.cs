using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            Camera1.active = true;
            Camera2.active = false;
            Camera3.active = false;

        }
        if (Input.GetKey(KeyCode.X))
        {
            Camera1.active = false;
            Camera2.active = true;
            Camera3.active = false;

        }

        if (Input.GetKey(KeyCode.C))
        {
            Camera1.active = false;
            Camera2.active = false;
            Camera3.active = true;

        }
    }



}
