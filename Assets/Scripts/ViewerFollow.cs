using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerFollow : MonoBehaviour
{
    public Transform target;
    public float posX;
    public float posZ;

    void Update() {
        posX = target.position.x - transform.position.x;
        posZ = target.position.z - transform.position.z;

        //if (posX > 100 || posZ > 100) {
            transform.position = new Vector3(target.position.x, 1.3f, target.position.z);
        //}

        //transform.position = new Vector3(target.position.x, 1.3f, target.position.z);
    }
}
