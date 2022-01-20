using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;
    [SerializeField] TMP_Text hint;
    [SerializeField] TMP_Text healthCount;
    [SerializeField] TMP_Text playerName;
    private PlayerController playerController;
    private int i = 0;

    void Start()
    {
        StartCoroutine(Instructions());
        playerController = GetComponentInParent<PlayerController>();
        playerName.text = PhotonNetwork.NickName;
    }

    private void Update()
    {
        healthCount.text = playerController.currentHealth.ToString()+"/100";
    }

    IEnumerator Instructions()
    {
        while (i < Mathf.Infinity)
        {
            hint.text = "Hint: Press ESC to get back the mouse cursor!";
            yield return new WaitForSecondsRealtime(5);
            hint.text = "Hint: You could press E to increase your speed!";
            yield return new WaitForSecondsRealtime(5);
            hint.text = "Hint: Player can double jump!";
            yield return new WaitForSecondsRealtime(5);
            hint.text = "Hint: You can change your gun by using the mousewheel!";
            yield return new WaitForSecondsRealtime(5);
        }
        
    }
}
