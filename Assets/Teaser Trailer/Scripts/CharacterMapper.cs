﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMapper
{
    public static int GetIndex(char c)
    {
        const string chars = " .-:+=*#%$@";
        int index = chars.IndexOf(c);
        return index == -1 ? 0 : index;
    }

    readonly public static string[] testMap = new string[36]
    {
        "+                                                              +",
        "                                                                " ,
        "                                                                " ,
        "                                                                " ,
        "                                                                " ,
        "                                                                " ,
        "                                                                " ,
        "                ################################                " ,
        "                #...................-----------#                " ,
        "                #.....................---------#                " ,
        "                #......................--------#                " ,
        "                #......$..................-----#                " ,
        "                #............................--#                " ,
        "                #..............................#                " ,
        "                #..............................#                " ,
        "                #..............................#                " ,
        "                #..............................#                " ,
        "                #.............@................#                " ,
        "                #..............................#                " ,
        "                #..............................#                " ,
        "                #..............................#                " ,
        "                #..............................#                " ,
        "                #...................$..........#                " ,
        "                #................$....$........#                " ,
        "                #.................$......$.....#                " ,
        "                #..............................#                " ,
        "                #..............................#                " ,
        "                #..............................#                " ,
        "                ################################                " ,
        "                                                                " ,
        "                                                                " ,
        "                                                                " ,
        "                                                                " ,
        "                                                                " ,
        "                                                                " ,
        "+                                                              +"
    };

}
