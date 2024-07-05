using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Magic : Card
{
    [SerializeField] public bool isUseOnOpponent;
    [SerializeField] protected DamageType damageType;
    [SerializeField] protected float damage = 0f;
    private TMP_Text cardUser;

    public abstract void MagicFX(string userTag, GameObject tartget);


    public void Execute(GameObject user, GameObject target)
    {
        string userTag = user.tag;
        cardUser = user.GetComponentInChildren<TMP_Text>();
        if (!ValidationTarget(userTag, target.tag)) { return; }

        MagicFX(userTag, target);

        if (isUseOnOpponent)
        {
            var damagable = target.GetComponent<IDamagable>();
            if (damagable != null)
            {
                damagable.Damage(damage, damageType);
                cardUser.text = cardName;
                Invoke(nameof(DelayedText), 1);
                if (userTag == "Player")
                { Destroy(gameObject); }
            }
        }
        else { Debug.Log("Use on the same team"); }
    }

    private void DelayedText(GameObject user)
    {
        cardUser.text = "";
    }

    protected bool ValidationTarget(string userTag, string tartgetTag)
    {
        if (isUseOnOpponent && userTag != tartgetTag)
        {
            return true;
        }
        else if (!isUseOnOpponent && userTag == tartgetTag)
        {
            return true;
        }
        return false;
    }
}
