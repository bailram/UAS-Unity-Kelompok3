using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOff : MonoBehaviour
{
    // private void OnTriggerEnter(BoxCollider2D other)
    // {
    //     if (other.tag == "Player")
    //         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // }
    [SerializeField]
    string strTag;

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.collider.tag == strTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
