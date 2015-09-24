using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager_EndToggle1 : MonoBehaviour
{

    [SerializeField]
    Toggle toggle;

    public void Awake()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("end1", 1);
            Debug.Log("end1, 1");

        }

        else
        {
            PlayerPrefs.SetInt("end1", 0);
            Debug.Log("end1, 0");

        }
    }
}
