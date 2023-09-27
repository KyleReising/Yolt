using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Unity.Netcode;

public class playerNet : NetworkBehaviour
{
    public float speed;
    void Update()
    {
        if (!IsOwner)   return;



        Vector3 moveVec = Vector3.zero;

        moveVec.x = Input.GetAxis("Horizontal");
        moveVec.z = Input.GetAxis("Vertical");

        transform.position += moveVec * speed * Time.deltaTime;
    }
}
