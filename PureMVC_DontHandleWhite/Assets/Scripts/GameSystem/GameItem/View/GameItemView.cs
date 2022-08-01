using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameItemView : MonoBehaviour, IPointerClickHandler
{

	float speed = 1;
	Image image;
	public bool isBlack;
	Color beClick = Color.gray;
    public UnityAction scoreUpAction;

    void Awake () {
		image = transform.GetComponent<Image>();
        RefreshColor();
	}

	void Update () {
		transform.position += Vector3.down * speed;
        if (transform.position.y < -34)
        {
			Refresh();
        }
	}

    private void Refresh()
    {
        RefreshPos();
        RefreshColor();
    }

    private void RefreshColor()
    {
        int rand = UnityEngine.Random.Range(0, 100);
        if (rand >= 25)
        {
            image.color = Color.white;
        }
        else
        {
            image.color = Color.black;
            isBlack = true;
        }
    }

    private void RefreshPos()
    {
        transform.position = new Vector3(transform.position.x, 466, transform.position.z);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
		if (isBlack)
        {
			image.color = beClick;
            if (scoreUpAction != null)
            {
                scoreUpAction();
            }
            else
                (ApplicationFacade.Instance.RetrieveProxy(GameProxy.NAME) as GameProxy).SendNotification(GameMsgDefine.GameCommand);
        }
    }
}
