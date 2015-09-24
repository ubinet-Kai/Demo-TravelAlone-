using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager_EndToggle : MonoBehaviour
{

    [SerializeField]
    Toggle toggle;

    public void Awake()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("end", 1);
            Debug.Log("end, 1");

        }

        else
        {
            PlayerPrefs.SetInt("end", 0);
            Debug.Log("end, 0");

        }
    }
}
