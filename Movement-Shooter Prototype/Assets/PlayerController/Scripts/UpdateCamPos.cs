using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCamPos : MonoBehaviour
{
    public Transform playerCamPos;
    void Update()
    {
        transform.position = playerCamPos.position;
    }
}
