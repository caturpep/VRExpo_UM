        using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colliderIn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Terdeteksi");
        SceneManager.LoadScene("ExpoUM");
    }
}
