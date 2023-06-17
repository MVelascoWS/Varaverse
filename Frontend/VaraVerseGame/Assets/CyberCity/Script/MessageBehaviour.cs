using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;
public class MessageBehaviour : MonoBehaviour
{
    public TextMeshProUGUI[] entries;
    public TMP_InputField input;
    int index = 0;
    void Start()
    {
        
    }

    public void SetMessage()
    {
        if (index < entries.Length)
        {
            entries[index].text = input.text;
            index++;
            input.text = "";
        }
    }
}
