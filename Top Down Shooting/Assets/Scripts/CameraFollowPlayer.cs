using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform PlayerPosition;
    void Start()
    {

    }
    void Update()
    {
        transform.position = new Vector3(PlayerPosition.position.x, PlayerPosition.transform.position.y, -10);
    }
}
