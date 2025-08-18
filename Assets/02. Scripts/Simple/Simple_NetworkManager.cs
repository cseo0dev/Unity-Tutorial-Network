using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

// MonoBehaviourPunCallbacks -> �Ŵ����� �� ���
// MonoBehaviourPun -> ������!
public class Simple_NetworkManager : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1";

    void Awake()
    {
        Screen.SetResolution(1920, 1080, false); // �ػ� ����, false = Full Screen ��� ����
        PhotonNetwork.SendRate = 60; // �� ��ǻ�� ���� ������ ���� ���۷�
        PhotonNetwork.SerializationRate = 30; // Photon View ���� ���� ��� ���� ���۷�
        PhotonNetwork.GameVersion = gameVersion;
    }

    void Start()
    {
        Connect();
    }

    private void Connect()
    {
        PhotonNetwork.ConnectUsingSettings(); // App ID ������� ����
        Debug.Log("���� ����");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 20}, null);
        Debug.Log("���� ���� �Ϸ�");
    }

    public override void OnJoinedRoom()
    {
        // ��Ʈ��ũ �� ���� (/Assets/Resource ������ �ִ� "Player" �̸��� ������Ʈ ����)
        PhotonNetwork.Instantiate("Player", Vector3.up, Quaternion.identity);

        Debug.Log("ĳ���� ����");
    }
}
