using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZInput;
public class KeyMapTest : MonoBehaviour
{
    KeyBinds keyBind;
    void Start()
    {
        DefaultKeys();
    }
    void Update()
    {
        if (Input.GetKeyDown(keyBind["KEY"]))
        {
            Debug.Log("Key Pressed :: " + keyBind["KEY"].ToString());
        }
    }
    public void DefaultKeys()
    {
        Dictionary<string, KeyCode> pairs = new Dictionary<string, KeyCode>();
        pairs.Add("KEY", KeyCode.E);

        keyBind = new KeyBinds(pairs, false);

    }
}
