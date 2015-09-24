using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager_StartToggle : MonoBehaviour {

    [SerializeField]
    Toggle toggle;

    public void Awake()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("start", 1);
            Debug.Log("start, 1");

        }

        else
        {
            PlayerPrefs.SetInt("start", 0);
            Debug.Log("start, 0");

        }
    }
}
