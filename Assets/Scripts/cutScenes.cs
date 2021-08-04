using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutScenes : MonoBehaviour
{

    public GameObject player;
    public GameObject cutScene;

    // Start is called before the first frame update
    void Start()
    {
        cutScene.SetActive(true);
        player.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(5);
        player.SetActive(true);
        cutScene.SetActive(false);
    }
}
