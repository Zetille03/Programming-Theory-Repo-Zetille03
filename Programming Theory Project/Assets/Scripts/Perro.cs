using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Perro : Animal
    {

        public override void Jump()
        {
            Debug.Log("salta");
            rb.AddRelativeForce(Vector3.up * 7500 * Time.deltaTime);
        }

        
    }
}