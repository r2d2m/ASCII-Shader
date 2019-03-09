﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTextureFactory
{
    MapTextureFactory()
    {
        // todo:
        // - input
        //      tile textures
        //      a map definition, represented either as a string or as a texture
        //      a legend, some way to translate the mapDefinition to tiles
        // - output
        //      a texture of tiles
    }

    static Texture2D CreateMapTexture(Vector2Int mapSize, int tilePixelSize, Texture2D[] tiles, string mapDefinition, Dictionary<char, byte> legend)
    {
        // - Create texture
        Texture2D tex = null;
        
        for (int y = 0; y < mapSize.y; ++y)
        {
            for (int x = 0; x < mapSize.x; ++x)
            {
                // draw tile at position (SetPixels, I guess)
            }
        }

        return tex;
    }

    static Texture2D CreateMapTexture(Vector2Int numTiles, Texture2D[] tiles, Texture2D mapDefinition, Dictionary<Color32, byte> legend)
    {
        // Do like the string version, but use colors from the mapDefinition texture instead of chars.
        return null;
    }

}
