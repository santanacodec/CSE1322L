﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    class Encryption
    {
        List<char> symbols = new List<char>();
        List<char> alphabets = new List<char>();

        public Encryption()
        {
            symbols.Add('!');
            symbols.Add('@');
            symbols.Add('#');
            symbols.Add('$');
            symbols.Add('^');
            symbols.Add('&');
            symbols.Add('*');
            symbols.Add('(');
            symbols.Add(')');
            symbols.Add(' ');
            symbols.Add('-');
            symbols.Add('+');
            symbols.Add('=');
            symbols.Add('?');
            symbols.Add(',');
            symbols.Add('{');
            symbols.Add('}');
            symbols.Add('[');
            symbols.Add(']');
            symbols.Add('/');
            symbols.Add('|');
            symbols.Add(';');
            symbols.Add(':');
            symbols.Add('.');
            symbols.Add('<');
            symbols.Add('>');

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                alphabets.Add(letter);
            }
        }           
        
    }
}
