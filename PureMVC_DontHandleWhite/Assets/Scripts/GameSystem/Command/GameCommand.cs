using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCommand : SimpleCommand {

    public override void Execute(INotification notification)
    {
        GameProxy gameProxy = Facade.RetrieveProxy(GameProxy.NAME) as GameProxy;
        gameProxy.ScoreUp();
    }
}
