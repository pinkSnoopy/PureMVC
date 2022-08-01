using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProxy : Proxy {

	public new const string NAME = "GameProxy";
    public int Score
    {
        get { return (int)base.Data; }
        set { base.Data = value; }
    }
    public GameProxy() : base(NAME, 0)
    {

    }
    public override void OnRegister()
    {
        base.OnRegister();
    }

    public void ScoreUp()
    {
        Score++;
        SendNotification(GameMsgDefine.RefreshScore, Score);
    }
}
