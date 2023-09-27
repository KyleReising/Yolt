using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class netManUI : MonoBehaviour
{
    [SerializeField]private Button serb;
    [SerializeField] private Button client;
    [SerializeField] private Button host;

    private void Awake()
    {
        serb.onClick.AddListener(() => { NetworkManager.Singleton.StartServer(); });
        client.onClick.AddListener(() => { NetworkManager.Singleton.StartClient(); });
        host.onClick.AddListener(() => { NetworkManager.Singleton.StartHost(); });
    }
}
