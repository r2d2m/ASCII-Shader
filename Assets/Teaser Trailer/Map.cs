﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(SpriteRenderer))]
public class Map : MonoBehaviour
{
    readonly int pixelWidth = 1920;
    readonly int pixelHeight = 1080;
    readonly int width = 64;
    readonly int height = 36;
    readonly int tileSize = 40;
    readonly int pixelsPerUnit = 30;

    Tileset tileset;
    Texture2D texture;
    Sprite sprite;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        texture = new Texture2D(pixelWidth, pixelHeight, TextureFormat.ARGB32, false);
        texture.FillWithColor(new Color32(250, 158, 51, 255));

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Sprite.Create(texture, new Rect(0f, 0f, pixelWidth, pixelHeight), new Vector2(0.5f, 0.5f), pixelsPerUnit);

        //tileset = new Tileset("Spritesheet 40");
        //mapTexture = MapTextureFactory.CreateMapTexture(64, 36, 40, null, null, null); // todo: fill this in
        //sprite.

        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
            }
        }

        //PopulateFromCharacterMap(CharacterMapper.sampleCharacterMapSource);
    }

    /*
    private SpriteRenderer CreateRendererAt(int x, int y)
    {
        string name = "Tile[" + x + "," + y + "]";
        GameObject go = new GameObject(name);
        SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
        SetPosition(x, y, sr);
        return sr;
    }

    private void SetPosition(int x, int y, SpriteRenderer rend)
    {
        float _x = x - (width / 2) + 0.5f;
        float _y = -y + (height / 2) - 0.5f;
        rend.transform.localPosition = new Vector3(_x, _y, 0f);
    }

    private void PopulateFromCharacterMap(string characterMap)
    {
        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                char c = characterMap[y*width + x];
                int index = CharacterMapper.GetIndex(c);
                Sprite sprite = tileset.GetTile(index);
                renderers[x,y].sprite = sprite;
            }
        }
    }
    */

    void Update()
    {
        //StressTest.Do(tileset, width, height, renderers);
    }

}


