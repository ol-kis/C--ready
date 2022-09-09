# -*- coding: utf-8 -*-
"""
Created on Fri Sep  9 09:20:59 2022

@author: kiseleva_od
"""

Console.WriteLine("Write some words");
string [] words= Console.ReadLine().Split(',');
string [] words_Length= new string[words.Length];
for (int i=0;i<words.Length;i++){
    if (words[i].Length<=3){
        Console.Write($"{words[i]} ");
        words_Length[i]=words[i];
    }
        }
        Console.WriteLine(); 


      