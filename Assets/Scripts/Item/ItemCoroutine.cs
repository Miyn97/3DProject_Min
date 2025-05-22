using System.Collections;
using UnityEngine;

public class ItemCoroutine : MonoBehaviour
{
    private PlayerCondition condition;

    private void Start()
    {
        if (CharacterManager.Instance == null || CharacterManager.Instance.Player == null)
        {
            Debug.LogError("CharacterManager.Instance.Player가 존재하지 않음!");
            return;
        }

        condition = CharacterManager.Instance.Player.condition;

        if (condition == null)
        {
            Debug.LogError("Player.condition이 존재하지 않음!");
        }
    }

    public void StartContinuousRecovery(ItemData itemData)
    {
        StartCoroutine(RecoverOverTime(itemData));
    }

    private IEnumerator RecoverOverTime(ItemData itemData)
    {
        float duration = 7f;      // 총 지속 시간
        float interval = 1f;      // 1초마다 회복
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
