using System.Collections;
using Photon.Pun;
using UnityEngine;

public class Simple_GameManager : MonoBehaviour
{
    // �濡 �����ϱ� ���� �۵��Ǹ� ����
    IEnumerator Start()
    {
        yield return null; // ����ȭ ���������� Ÿ�̹� ������?

        PhotonNetwork.Instantiate("Player", Vector3.up, Quaternion.identity);
    }
}
