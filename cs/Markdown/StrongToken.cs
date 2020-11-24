﻿using System.Collections.Generic;

namespace Markdown
{
    public class StrongToken : Token
    {
        public StrongToken(int position, string value, int endPosition)
            : base(position, value, endPosition, TokenType.Strong, true)
        {
        }
    }
}