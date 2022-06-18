using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour
{
    public float runSpeed = 1500f;
    float horizontalMove = 0f;

    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

 
}
