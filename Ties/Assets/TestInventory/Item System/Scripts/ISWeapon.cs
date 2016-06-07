﻿using UnityEngine;
using System.Collections;
using System;

namespace BurgZerArcade.ItemSystem
{
    [System.Serializable]
    public class ISWeapon : ISObject, IISWeapon, IISDestructable, IISEquipable, IISGameObject
    {
        [SerializeField] int _durability;
        [SerializeField] int _maxDurability;
        [SerializeField] int _minDamage;
        [SerializeField] ISEquipmentSlot _equipmentSlot;
        [SerializeField] GameObject _prefab;

        public ISWeapon ()
        {
            _equipmentSlot = new ISEquipmentSlot();
            _prefab = new GameObject();
        }
        public ISWeapon(int durability, int maxDurability, ISEquipmentSlot equipmentSlot, GameObject prefab)
        {
            _durability = durability;
            _maxDurability = maxDurability;
            _equipmentSlot = equipmentSlot;
            _prefab = prefab;
        }

        public int Durability
        {
            get { return _durability; }
       
        }

        public ISEquipmentSlot EquipmentSlot
        {
            get
            {
                return _equipmentSlot;
            }
        }

        public int MaxDurability
        {
            get
            {
                return _maxDurability;
            }
        }
       
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        public GameObject Prefab
        {
            get
            {
                return _prefab;
            }
        }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public void Break()
        {
            _durability = 0;

        }

        public bool Equip()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int amount)
        {
            _durability -= amount;

            if (_durability < 0)
                _durability = 0;

        }

        public void Repair()
        {
            _maxDurability--;
            if(_maxDurability > 0)
            _durability = _maxDurability;
        }
    }
}
