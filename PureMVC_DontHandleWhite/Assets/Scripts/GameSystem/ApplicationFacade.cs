using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationFacade : Facade {
    public new static IFacade Instance
    {
        get
        {
            if (m_instance == null)
            {
                lock (m_staticSyncRoot)
                {
                    if (m_instance == null)
                    {
                        m_instance = new ApplicationFacade();
                    }
                }
            }
            return m_instance;
        }
    }
    public void Start(MainUI main)
    {
        SendNotification(GameMsgDefine.StartCommand, main);
    }
    protected override void InitializeFacade()
    {
        base.InitializeFacade();
    }
    protected override void InitializeModel()
    {
        base.InitializeModel();
    }
    protected override void InitializeView()
    {
        base.InitializeView();
    }
    protected override void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(GameMsgDefine.StartCommand, typeof(StartCommand));
    }
}
