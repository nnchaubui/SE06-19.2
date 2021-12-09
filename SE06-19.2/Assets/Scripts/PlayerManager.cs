using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviour
{

    PhotonView PV;

    private void Awake()
    {
        PV = GetComponent<PhotonView>();
    }
    private void Start()
    {
        if (PV.IsMine)
        {
            createController();
        }
    }

    void createController()
    {
        //instantiating player controller
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerController"), Vector3.zero, Quaternion.identity);
    }
}
