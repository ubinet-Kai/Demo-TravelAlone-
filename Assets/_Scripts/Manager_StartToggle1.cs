using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager_StartToggle1 : MonoBehaviour
{

    [SerializeField]
    Toggle toggle;

    public void Awake()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("start1", 1);
            Debug.Log("start1, 1");

        }

        else
        {
            PlayerPrefs.SetInt("start1", 0);
            Debug.Log("start1, 0");

        }
    }
}
