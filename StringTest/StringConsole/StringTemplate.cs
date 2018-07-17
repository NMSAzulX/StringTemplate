using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace StringConsole
{
    public class StringTemplate
    {
        private static int CharSize;

        static StringTemplate()
        {
            CharSize = sizeof(char);
        }

        private char[][] _cache;
        
        private char[] _template;
        private int _offset;
        private int _realOffset;

        private int _min;
        public int Min
        {
            get { return _min; }
            set
            {
                if (0 < value)
                {
                    if (value < _min)
                    {
                        _min = value;
                    }
                    StretchCache(value);
                }
            }
        }

        private int _max;
        public int Max
        {
            get { return _max; }
            set
            {
                if (value > _max)
                {
                    int old = _max + 1;

                    char[][] newCache = new char[value+1][];
                    Array.Copy(_cache, newCache, _cache.Length);
                    _cache = newCache;

                    _max = value;
                    for (int i = old; i <= value; i+=1)
                    {
                        StretchCache(i);
                    }
                }
            }
        }


        public StringTemplate(string template) : this(template, 1, 3)
        {

        }
        public StringTemplate(string template, int max) : this(template, 1, max)
        {

        }
        public StringTemplate(string template, int min, int max)
        {
            _template = template.ToCharArray();
            for (int i = 0; i < _template.Length; i += 1)
            {
                if (_template[i] == 9312)
                {
                    _offset = i;
                    _realOffset = _offset * CharSize;
                    break;
                }
            }

            _min = min;
            _max = max;
            _cache = new char[max+1][];
            for (int i = _min; i <= _max; i++)
            {
                StretchCache(i);
            }
        }

        /// <summary>
        /// make template by Fill-String's length.
        /// </summary>
        /// <param name="valueLength">Fill-String's length</param>
        private void StretchCache(int valueLength)
        {
            if (valueLength<=_max)
            {
                if (_cache[valueLength]==null)
                {
                    var newChars = new char[_template.Length + valueLength-1];
                    Buffer.BlockCopy(_template, 0, newChars, 0, _realOffset);
                    Buffer.BlockCopy(_template, (_offset + 1) * CharSize, newChars, (_offset + valueLength) * CharSize, (_template.Length - _offset - 1) * CharSize);
                    _cache[valueLength] = newChars;
                }
            }
        }
        /// <summary>
        /// Format the template stored in cache.
        /// </summary>
        /// <param name="value">fill string</param>
        /// <returns>result</returns>
        public string Format(string value)
        {
            int length = value.Length;

            if (length <= _max)
            {
                if (_cache[length] != null)
                {
                    var chars = _cache[length];
                    for (int i = 0; i < length; i += 1)
                    {
                        chars[_offset + i] = value[i];
                    }
                    return new string(chars);
                }
            }
            return null;
        }
        /*
        public string Fill(string value)
        {
            int length = value.Length;
            if (length <= _max)
            {
                if (_cache[length] != null)
                {
                    var chars = _cache[length];
                    Buffer.BlockCopy(value.ToCharArray(), 0, chars, _realOffset, length * CharSize);
                    return new string(chars);
                }
            }
            return null;
        }*/
    }
}
