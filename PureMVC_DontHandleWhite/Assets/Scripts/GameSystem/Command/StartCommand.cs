using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCommand : SimpleCommand {

    public override void Execute(INotification notification)
    {
        GameProxy gameProxy = new GameProxy();
        Facade.RegisterProxy(gameProxy);

        MainUI ui = notification.Body as MainUI;
        Facade.RegisterMediator(new GameMediator(ui.GameView));

        Facade.RegisterCommand(GameMsgDefine.GameCommand, typeof(GameCommand));
    }
}
