using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour {

    public static HealthBar instance;
    public Image currentHealthBar;
    public Text RatioText;

    private float hitPoint = 150;
    private float maxHitPoint = 150;


    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        updateHealthBar();

    }

    public void updateHealthBar()
    {
        float ratio = hitPoint / maxHitPoint;
        currentHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        RatioText.text = (ratio * 100).ToString("0") + "%";
    }

    public void TakeDamage(float damage)
    {
        hitPoint -= damage / 10;
        if(hitPoint < 0)
        {
            hitPoint = 0;
            Debug.Log("dead");
        }
        updateHealthBar();
        
    }
    public void HealDamage(float heal)
    {
        hitPoint += heal;
        if(hitPoint > maxHitPoint)
        {
            hitPoint = maxHitPoint;
        }
        updateHealthBar();
    }
}
