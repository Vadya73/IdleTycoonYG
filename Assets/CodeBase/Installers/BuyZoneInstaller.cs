using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Behaviours;
using CodeBase.Behaviours.Observers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Installers
{
    public class BuyZoneInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private GameObject _prefabBuilding;
        [SerializeField] private Transform _buildTransform;
        [SerializeField] private WalletType _walletType;
        [SerializeField] private ReactiveVariable<int> _cost;
        [SerializeField] private GameObject _destroyObjectOnBuy;
        [SerializeField] private ReactiveVariable<int> _secondsToBuild;
        [SerializeField] private Image _progressBarImage;
        [SerializeField] private TMP_Text _progressText;

        public override void Install(IEntity entity)
        {
            if (!_destroyObjectOnBuy)
                _destroyObjectOnBuy = this.gameObject;
            
            entity.AddWalletType(_walletType);
            entity.AddCost(_cost);
            entity.AddOnPurchaseEvent(new BaseEvent());
            entity.AddBuildingPrefab(_prefabBuilding);
            entity.AddBuildingTransform(_buildTransform);
            entity.AddDestroyObject(_destroyObjectOnBuy);
            entity.AddOnTriggerEnterAction(new BaseEvent<Collider>());
            entity.AddOnTriggerExitAction(new BaseEvent<Collider>());
            entity.AddOnPurchaseEvent(new BaseEvent());
            entity.AddSecondsForWaiting(_secondsToBuild);
            entity.AddProgressBarImage(_progressBarImage);
            entity.AddOnProgressStart(new BaseEvent());
            entity.AddOnProgressCancel(new BaseEvent());
            entity.AddProgressText(_progressText);

            entity.AddBehaviour(new WaitProgressBehaviour());
            entity.AddBehaviour(new PurchaseCheckBehaviour());
            entity.AddBehaviour(new BuildBehaviour());
            entity.AddBehaviour(new BuyZoneObserveBehaviour());
            entity.AddBehaviour(new BuildObserverBehaviour());
            entity.AddBehaviour(new DestroyGameObjectBehaviour());
            entity.AddBehaviour(new ShowUIProgressBehaviour());
        }
    }
}