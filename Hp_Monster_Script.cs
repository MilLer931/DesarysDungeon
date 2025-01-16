using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Monster_Script : MonoBehaviour
{
	public Image image_hp_monster;
	public float fill;
	public float hp_monster;
	public float damage;
	public Text text_hp_monster;
	[SerializeField] bool isDead;

	// Start us cakked befire the first frame update
	void Start()
	{
		damage = 10;
		hp_monster = 100;
		//PlayerPrefs.SetFloat("HP_Monster", 1f);
		fill = PlayerPrefs.GetFloat("HP_Monster");
		isDead = false;
	}

	public void ButtonClick()
	{
		fill -= damage/hp_monster;
		PlayerPrefs.SetFloat("HP_Monster", fill);
	}

	// Update is called once per frame
	void Update()
	{
		if (fill > 0)
		{
			iamge_hp_monster.fillAmount = fill;
			text_hp_monster.text = ((int)(fill * hp_monster)).ToString() + "/" + hp.monster.ToString();
		}
		else
		{
			if (!isDead)
			{
				PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money")+ 280);
				PlayerPrefs.SetFloat("HP_Monster", 1f);
			}
			image_hp_monster.fillAmount = 1f;

