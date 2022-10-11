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

    // �ӽ÷� �������� ���õ� �ͷ� �����͸� ����
    private TurretBlueprint turretToBuild;


    // �������� Ÿ���� ������ �Ǿ����� turretToBuild�� �����ؼ� true, ������ �ȵǾ����� false
    public bool CanBuild 
    {
        get
        {
            return turretToBuild != null;
        }
    }

    // �ڡڡ� �ͷ� �Ǽ�.
    public void BuildTurretOn (Node node)
    {
        // ������尡 �����ϴٸ�, �Ǽ��Ұ�
        if (PlayerStats.Money < turretToBuild.cost)
        {
            return;
        }

        // Ÿ�� ���ݸ�ŭ ������� ����
        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }

    // �������� Ÿ���� ������ �Ǿ����� turretToBuild�� �ͷ������Ͱ� ����, turret��ġ�� �غ��.
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
