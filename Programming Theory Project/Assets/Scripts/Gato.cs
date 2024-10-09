using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gato : Animal
{

    public override void Jump()
    {
        Debug.Log("salta");

        rb.AddRelativeForce(new Vector3(0, 1, 0) * 10000 * Time.deltaTime);
    }

    
}
