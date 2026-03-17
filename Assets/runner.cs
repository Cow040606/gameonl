using UnityEngine;
using Fusion;

public class runner : SimulationBehaviour, IPlayerJoined
{
    [SerializeField]
    NetworkObject playerPrefab;

    public void PlayerJoined(PlayerRef player)
    {
        if(player == Runner.LocalPlayer)
        {
            // Cộng thêm tọa độ ngẫu nhiên từ -2 đến 2 vào trục X và Z
            Vector3 toaDoDe = new Vector3(173.7f + Random.Range(-2f, 2f), 1, 114.7f + Random.Range(-2f, 2f));
            
            Runner.Spawn(playerPrefab, toaDoDe, Quaternion.identity, player);
        }
    }
}