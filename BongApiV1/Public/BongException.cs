﻿using System;

namespace BongApiV1.Public
{
    public class BongException : Exception
    {
        public BongException() { }
        public BongException(string message) : base(message) { }
    }
}