using UnityEngine;

using TMPro;
using Photon.Realtime;
using Photon.Pun;


public class PlayerListItem : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_Text text;
    Photon.Realtime.Player player;

    public void SetUp(Photon.Realtime.Player _player)
    {
        player = _player;
        text.text = _player.NickName;
    }
    public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer)
    {
        if (player == otherPlayer)
        {
            Destroy(gameObject);
        }
    }

    public override void OnLeftRoom()
    {
        Destroy(gameObject);
    }
}
