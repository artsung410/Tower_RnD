using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }

        instance = this;
    }

    // 임시로 상점에서 선택된 터렛 데이터를 저장
    private TurretBlueprint turretToBuild;


    // 상점에서 타워가 선택이 되었으면 turretToBuild는 존재해서 true, 선택이 안되었으면 false
    public bool CanBuild 
    {
        get
        {
            return turretToBuild != null;
        }
    }

    // ★★★ 터렛 건설.
    public void BuildTurretOn (Node node)
    {
        // 소지골드가 부족하다면, 건설불가
        if (PlayerStats.Money < turretToBuild.cost)
        {
            return;
        }

        // 타워 가격만큼 소지골드 차감
        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }

    // 상점에서 타워가 선택이 되었으면 turretToBuild에 터렛데이터가 담기고, turret설치가 준비됨.
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
