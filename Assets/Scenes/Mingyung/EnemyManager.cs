using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;  

public class EnemyManager : MonoBehaviour
{
    public Enemy enemyData;  // ���� �����Ͱ� ����ִ� ScriptableObject
    public List<Image> enemyImages; // ���� �� ��������Ʈ�� ǥ���� UI Image ����Ʈ
    public List<TextMeshProUGUI> enemyInfoTexts;  // ���� �� ������ ǥ���� UI Text ����Ʈ

    void Start()
    {
        // ���� ���� ���� ������ ó��
        SetEnemyInfo("scarecrow", 0);  // ù ��° UI ��ҿ� ����ƺ� ���� ǥ��
        SetEnemyInfo("devil", 1);       // �� ��° UI ��ҿ� �Ǹ� ���� ǥ��
    }

    // ���� ������ �̹����� �����ϴ� �Լ�
    private void SetEnemyInfo(string enemy_name, int index)
    {
        EnemyTest scarecrowData = GetEnemyData("scarecrow");

        if (scarecrowData != null)
        {
            // �� �̹��� ����
            enemyImages[index].sprite = Resources.Load<Sprite>("Sprites/" + "scarecrow");

            // �� ���� �ؽ�Ʈ ����
            enemyInfoTexts[index].text = "enemy_name: " + scarecrowData.enemy_name + "\n" +
                                         "HP: " + scarecrowData.HP + "\n" +
                                         "attack: " + scarecrowData.attack + "\n" +
                                         "speed: " + scarecrowData.speed + "\n" +
                                         "defense: " + scarecrowData.defense + "\n" +
                                         "stiffness_resistance: " + scarecrowData.stiffness_resistance;
        }
        else
        {
            Debug.LogError("scarecrow" + " �����͸� ã�� �� �����ϴ�.");
        }
    }

    private void devilEnemyInfo(string enemy_name, int index)
    {
        EnemyTest devilData = GetEnemyData("devil");

        if (devilData != null)
        {
            // �� �̹��� ����
            enemyImages[index].sprite = Resources.Load<Sprite>("Sprites/" + "devil");

            // �� ���� �ؽ�Ʈ ����
            enemyInfoTexts[index].text = "enemy_name: " + devilData.enemy_name + "\n" +
                                         "HP: " + devilData.HP + "\n" +
                                         "attack: " + devilData.attack + "\n" +
                                         "speed: " + devilData.speed + "\n" +
                                         "defense: " + devilData.defense + "\n" +
                                         "stiffness_resistance: " + devilData.stiffness_resistance;
        }
        else
        {
            Debug.LogError("devil" + " �����͸� ã�� �� �����ϴ�.");
        }
    }

    // �������� �� �����͸� �������� �Լ�
    private EnemyTest GetEnemyData(string enemyName)
    {
        foreach (var enemy in enemyData.EnemyStats)
        {
            if (enemy.enemy_name == enemyName)
            {
                return enemy;
            }
        }
        return null;  // ã�� ���� ��� null ��ȯ
    }
}






//�� �߿� �Ѹ����� ��Ʈ�� �ִ� ������ ������Ѻ��� �������� ������ Ȯ�� 
// ��Ʈ�� �����Ű���� ĳ���� ������ �����, �� ĳ���͸� �������� ����..�⺻ ������ ���� �ǰ�...
