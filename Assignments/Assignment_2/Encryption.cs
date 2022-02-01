using System;
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
        
        public char return_alphabet(int input)
        {
            return alphabets[input];
        }

        public int return_alphabet_index(char input)
        {
            return alphabets.IndexOf(input);
        }

        public char return_symbol(int input)
        {
            return symbols[input];
        }

        public int return_symbol_index(char input)
        {
            return symbols.IndexOf(input);
        }
    }
}
