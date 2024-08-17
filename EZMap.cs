using UnityEngine;
using EZInput;
using System;
public class EZMap : MonoBehaviour
{
    bool remapping;
    string input;

    //Use with OnClick() Event
    public void Map(string input)
    {
        this.input = input;
        remapping = true;
    }
    private void Update()
    {
        if (remapping)
        {
            foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(key))
                {
                    KeyBinds.preset[input] = key;
                    remapping=false;
                }
            }
        }
    }
}
