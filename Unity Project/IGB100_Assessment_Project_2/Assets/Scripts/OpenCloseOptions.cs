using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseOptions : MonoBehaviour
{
    public GameObject OptionsMenu;

    public void ToggleEnable()
    {
        OptionsMenu.SetActive(!OptionsMenu.activeInHierarchy);
    }
}
