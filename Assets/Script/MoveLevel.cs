using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLevel : MonoBehaviour
{
    [SerializeField]
    string strTag;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.collider.tag == strTag)
            Application.LoadLevel("Scene 2 Lite");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
