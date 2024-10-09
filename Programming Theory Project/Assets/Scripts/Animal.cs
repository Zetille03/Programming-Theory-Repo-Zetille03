using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public Rigidbody rb { get; set; }
    public bool presionaSaltar { get; set; }

    private string _name;
    public string Name 
    { 
        get { return _name; }
        set { 
            if (value.Length <= 20) 
            {
                _name = value;
            }else
            {
                Debug.Log("The name is too long");
            }
        } 
    }


    // Use this for initialization
    protected virtual void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }


    protected virtual void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            presionaSaltar = true;
        }
    }

    protected virtual void FixedUpdate()
    {
        if (presionaSaltar)
        {
            Jump();
            presionaSaltar = false;
        }
    }

    public virtual void Jump() {
        rb.AddRelativeForce(Vector3.up * 5000 * Time.deltaTime);
    }
}
