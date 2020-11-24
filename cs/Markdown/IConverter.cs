﻿using System.Collections.Generic;

namespace Markdown
{
    public interface IConverter
    {
        string ConvertTokens(IEnumerable<Token> tokens);
    }
}