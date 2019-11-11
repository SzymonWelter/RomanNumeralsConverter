using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsConverter.Mapping
{
    interface IMapService<TFrom, TTo>
    {
        TTo Map(TFrom source);
    }
}
