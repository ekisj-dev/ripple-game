using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldController : MonoBehaviour
{
    public Vector2 direction;

    public float force;

    public Transform origin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(origin.position, direction.normalized);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Rigidbody2D rigidbody = collision.gameObject.GetComponent<Rigidbody2D>();

        if (null == rigidbody)
        {
            Debug.Log("Could not find rigidbody.");
            return;
        }

        rigidbody.AddForce(direction.normalized * force);
    }
}
