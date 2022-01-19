using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNameManager : MonoBehaviour
{
    [SerializeField] TMP_InputField usernameInput;
    
    public void OnUsernameInputValueChange()
    {
        string playerName = usernameInput.text;
        if (string.IsNullOrWhiteSpace(playerName))
        {
            PhotonNetwork.NickName = "Player " + Random.Range(0, 1000).ToString("0000");
        }
        else
        {
            PhotonNetwork.NickName = playerName;
        }
        
    }
}
