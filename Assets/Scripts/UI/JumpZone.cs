using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("점프할거다");
        if (!collision.gameObject.TryGetComponent(out Rigidbody rb))
            return;

        //Debug.Log("점프할거다2");
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        rb.AddForce(Vector3.up * 300f, ForceMode.Impulse);
    }
}
