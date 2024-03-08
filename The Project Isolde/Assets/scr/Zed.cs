using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zed : MonoBehaviour
{

    void Update()
    {
        gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.y * 0.001f);

    }
}
