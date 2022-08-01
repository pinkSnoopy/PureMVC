using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMediator : Mediator {

    public new const string NAME = "GameMediator";
    public GameView GameView
    {
        get { return (GameView)ViewComponent; }
    }
    public GameMediator(GameView gameView) : base(NAME, gameView)
    {
        gameView.scoreUpAction = () => { SendNotification(GameMsgDefine.GameCommand); };
    }
    public override void OnRegister()
    {
        base.OnRegister();
    }
    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>();
        list.Add(GameMsgDefine.RefreshScore);
        return list;
    }
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case GameMsgDefine.RefreshScore:
                GameView.SetScore((int)notification.Body);
                break;
            default:
                break;
        }
    }
}
