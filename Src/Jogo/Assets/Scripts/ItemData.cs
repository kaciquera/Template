﻿using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "Item_", menuName = "Itens/Item Data")]
    public class ItemData : ScriptableObject
    {
        [SerializeField] private string itemName;
        [SerializeField] private Sprite itemSprite;
        [SerializeField]
        private bool[,] originalItemSize = new bool[3, 3]
        {
            { true , true, false},
            { true , false, false},
            { true , false, false}
        };
    }
}