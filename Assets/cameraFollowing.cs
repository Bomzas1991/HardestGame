using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowing : MonoBehaviour
{
    public Transform player;
    public float height;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position - transform.forward * height;
    }
}
