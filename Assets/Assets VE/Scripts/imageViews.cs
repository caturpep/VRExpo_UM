using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageViews : MonoBehaviour
{
    public GameObject panel;

    public void bukaPanel()
    {
        panel.SetActive(true);
    }
    public void tutupPanel()
    {
        panel.SetActive(false);
    }
}
