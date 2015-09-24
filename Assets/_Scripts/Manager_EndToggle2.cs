using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager_EndToggle2 : MonoBehaviour
{

    [SerializeField]
    Toggle toggle;

    public void Awake()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("end2", 1);
            Debug.Log("end2, 1");

        }

        else
        {
            PlayerPrefs.SetInt("end2", 0);
            Debug.Log("end2, 0");

        }
    }
}
