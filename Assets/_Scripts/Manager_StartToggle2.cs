using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager_StartToggle2 : MonoBehaviour
{

    [SerializeField]
    Toggle toggle;

    public void Awake()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("start2", 1);
            Debug.Log("start2, 1");

        }

        else
        {
            PlayerPrefs.SetInt("start2", 0);
            Debug.Log("start2, 0");

        }
    }
}
