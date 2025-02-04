using Atomic.Entities;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Inventory
{
    public class Item : ScriptableObject
    {
        [SerializeField] protected string _name;
        [SerializeField] protected Image _image;
    }

    public class WorthItem : Item
    {
        
    }

    public class ResourceItem : Item
    {
        
    }

    public class InventoryInstaller : SceneEntityInstallerBase
    {
        public override void Install(IEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}