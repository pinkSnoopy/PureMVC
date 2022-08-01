using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameView : MonoBehaviour 
{
	Transform parent;
	Text score;
	List<GameItemView> items = new List<GameItemView>();
	public UnityAction scoreUpAction;

	void Awake()
    {
		parent = transform.Find("Parent");
        foreach (Transform item in parent)
        {
			GameItemView gameItemView = item.gameObject.AddComponent<GameItemView>();
			items.Add(gameItemView);
			gameItemView.scoreUpAction = scoreUpAction;
        }
		score = transform.Find("Score").GetComponent<Text>();
		score.text = "得分:0";
    }

	public void SetScore(int score)
    {
		this.score.text = "得分:" + score.ToString();
    }
}
