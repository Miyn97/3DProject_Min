using System.Collections;
using UnityEngine;

public class ItemCoroutine : MonoBehaviour
{
    private PlayerCondition condition;

    private void Start()
    {
        if (CharacterManager.Instance == null || CharacterManager.Instance.Player == null)
        {
            Debug.LogError("CharacterManager.Instance.Player�� �������� ����!");
            return;
        }

        condition = CharacterManager.Instance.Player.condition;

        if (condition == null)
        {
            Debug.LogError("Player.condition�� �������� ����!");
        }
    }

    public void StartContinuousRecovery(ItemData itemData)
    {
        StartCoroutine(RecoverOverTime(itemData));
    }

    private IEnumerator RecoverOverTime(ItemData itemData)
    {
        float duration = 7f;      // �� ���� �ð�
        float interval = 1f;      // 1�ʸ��� ȸ��
        float timer = 0f;

        while (timer < duration)
        {
            foreach (var c in itemData.consumables)
            {
                switch (c.type)
                {
                    case ConsumableType.Health:
                        condition.Heal(c.value);
                        break;
                    case ConsumableType.Hunger:
                        condition.Eat(c.value);
                        break;
                }
            }

            yield return new WaitForSeconds(interval);
            timer += interval;
        }
    }
}
