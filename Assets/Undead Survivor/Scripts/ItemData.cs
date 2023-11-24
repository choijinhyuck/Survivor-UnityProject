using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Object/ItemData")]
public class ItemData : ScriptableObject
{
public enum ItemType { Melee, Range, Glove, Shoe, Heal}

    [Header("# Main Info")]
    public ItemType itemType;
    public int itemId;
    public string itemName;
    public string itemDesc;
    public Sprite ItemIcon;

    [Header("# Level Data")]
    public float baseDamage;
    public int baseCount;
    public float[] damage;
    public int[] count;

    [Header("# Weapon")]
    public GameObject projectile;
    public Sprite hand;
}