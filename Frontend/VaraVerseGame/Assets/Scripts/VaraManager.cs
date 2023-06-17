using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VaraManager : MonoBehaviour
{
    public TextMeshProUGUI network;

    public void SetNetwork(string netName)
    {
        network.text = "Network: " + netName;
    }
}
